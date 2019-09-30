using CdcSoftware.Pivotal.Applications.Core.Common;
using CdcSoftware.Pivotal.Applications.Core.Server;
using CdcSoftware.Pivotal.Engine;
using CdcSoftware.Pivotal.Engine.Types.DataTemplates;
using CdcSoftware.Pivotal.Engine.Types.ServerTasks;
using PP.EF.Server.ServiceTasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;

namespace EdDbContext
{
    public class ContextFormTask : AbstractDataTemplateServerTask
    {
        public ContextFormTask()
        {
            //ContextFactory = new ContextFactory(SystemServer.DatabaseInformation.EDConnectionString);

            ModelEntities = typeof(Entities).GetProperties()
            .Where(p => p.PropertyType.IsGenericType && (typeof(IDbSet<>).IsAssignableFrom(p.PropertyType.GetGenericTypeDefinition()) || p.PropertyType.GetInterface(typeof(IDbSet<>).FullName) != null))
            .Select(p => p.PropertyType.GetGenericArguments()[0])
            .ToList();
        }

        private ContextFactory ContextFactory;
        private List<Type> ModelEntities;

        protected override Id AddData(DataTemplate dataTemplate, DataSet data, ParameterList parameters)
        {
            try
            {
                TransitionPointParameter.ParameterList = parameters;

                var primaryTableName = dataTemplate.PrimaryDataSection.Table.Name;
                Id newEntityId;
                using (var context = GetContext())
                {
                    newEntityId = AddData(context, SeedContextAdd(dataTemplate, data, context), primaryTableName);
                }

                TransitionPointParameter.CopyToParameterList(parameters);

                return newEntityId;
            }
            catch (Exception e)
            {
                throw new PivotalApplicationCoreException(e.Message, e);
            }
        }

        private object SeedContextAdd(DataTemplate dataTemplate, DataSet data, Entities context)
        {
            var primaryTableName = dataTemplate.PrimaryDataSection.Table.Name;
            var primaryKeyName = primaryTableName + "_Id";
            var primaryDataRow = data.Tables[dataTemplate.PrimaryDataSection.Name].Rows[0];

            var primaryEntityType = ModelEntities.Single(t => t.Name == primaryTableName);

            var primaryEntity = context.Set(primaryEntityType).Create();
            context.Set(primaryEntityType).Add(primaryEntity);
            var primaryEntityEntry = context.Entry(primaryEntity);

            SetCurrentValues(primaryEntityEntry, primaryDataRow, primaryKeyName);
          
            foreach (var secondary in dataTemplate.SecondaryDataSections)
            {
                var secondaryTableName = secondary.Name;
                var secondaryKeyName = secondaryTableName + "_Id";
                var secondaryEntityType = ModelEntities.Single(t => t.Name == secondaryTableName);

                foreach (DataRow row in data.Tables[secondaryTableName].Rows)
                {
                    var secondaryEntity = context.Set(secondaryEntityType).Create();                  
                    var secondaryEntityEntry = context.Entry(secondaryEntity);
                    context.Set(secondaryEntityType).Add(secondaryEntity);

                    SetCurrentValues(secondaryEntityEntry, row, secondaryKeyName);

                    var currentValue = primaryEntityEntry.Collection(secondaryTableName).CurrentValue;
                    var addMethod = currentValue.GetType().GetMethods().FirstOrDefault(m => m.Name == "Add");
                    addMethod.Invoke(currentValue, new object[] { secondaryEntity });
                }
            }

            return primaryEntity;
        }

        protected virtual Id AddData(Entities context, object primaryEntity, string tableName)
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                var entryIsProxy = entry.GetType().Namespace == "System.Data.Entity.DynamicProxies";

                if (entry.State == EntityState.Added)
                    SetRnColumns(entry, true, entryIsProxy ? entry.GetType().BaseType.Name : entry.GetType().Name);
                else if (entry.State == EntityState.Modified)
                    SetRnColumns(entry, false, entryIsProxy ? entry.GetType().BaseType.Name : entry.GetType().Name);
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                var log = new DiagnosticLog();
                log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.AddData.DBUpdateException", $"[{e.InnerException}]");
                throw;
            }
            catch (DbEntityValidationException e)
            {
                var log = new DiagnosticLog();
                foreach (var eve in e.EntityValidationErrors)
                {
                    log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.AddData.DbEntityValidationException", string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.AddData.DbEntityValidationException", string.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                throw;
            }
            catch (Exception e)
            {
                var log = new DiagnosticLog();
                log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.AddData.Exception", $"[{e.ToString()}][{e.InnerException}]");
                throw;
            }

            var primaryEntityEntry = context.Entry(primaryEntity);
                      
            return Id.Create(primaryEntityEntry.Property(tableName + "_Id").CurrentValue);
        }

        protected override void SaveData(DataTemplate dataTemplate, DataSet data, ParameterList parameters)
        {
            try
            {
                TransitionPointParameter.ParameterList = parameters;

                using (var context = GetContext())
                {
                    SaveData(context, SeedContextSave(dataTemplate, data, context));
                }

                TransitionPointParameter.CopyToParameterList(parameters);
            }
            catch (Exception e)
            {
                throw new PivotalApplicationCoreException(e.Message, e);
            }
        }

        private object SeedContextSave(DataTemplate dataTemplate, DataSet data, Entities context)
        {            
            string primaryTableName = dataTemplate.PrimaryDataSection.Table.Name;
            string primaryKeyName = primaryTableName + "_Id";
            var primaryDataRow = data.Tables[dataTemplate.PrimaryDataSection.Name].Rows[0];

            var primaryEntityType = ModelEntities.Single(t => t.Name == primaryTableName);
            var primaryEntity = context.Set(primaryEntityType).Find(primaryDataRow[primaryKeyName]);
            var primaryEntityEntry = context.Entry(primaryEntity);

            //ValidateOriginalValues(primaryEntityEntry, primaryDataRow, primaryKeyName);
            ValidateEditDate(primaryEntityEntry, primaryDataRow);

            SetCurrentValues(primaryEntityEntry, primaryDataRow, primaryKeyName);

            foreach (var secondary in dataTemplate.SecondaryDataSections)
            {
                string secondaryTableName = secondary.Name;
                string secondaryKeyName = secondaryTableName + "_Id";
                var secondaryEntityType = ModelEntities.Single(t => t.Name == secondaryTableName);

                foreach (DataRow row in data.Tables[secondaryTableName].Rows)
                {
                    switch (row.RowState)
                    {
                        case DataRowState.Deleted:
                            {
                                var entity = context.Set(secondaryEntityType).Find(row[secondaryKeyName, DataRowVersion.Original]);
                                context.Set(secondaryEntityType).Remove(entity);

                                break;
                            }
                        case DataRowState.Added:
                            {
                                var secondaryEntity = context.Set(secondaryEntityType).Create();
                                context.Set(secondaryEntityType).Add(secondaryEntity);
                                var secondaryEntityEntry = context.Entry(secondaryEntity);

                                SetCurrentValues(secondaryEntityEntry, row, secondaryKeyName);

                                var currentValue = primaryEntityEntry.Collection(secondaryTableName).CurrentValue;
                                var addMethod = currentValue.GetType().GetMethods().FirstOrDefault(m => m.Name == "Add");
                                addMethod.Invoke(currentValue, new object[] { secondaryEntity });

                                break;
                            }
                        case DataRowState.Modified:
                            {
                                var secondaryEntity = context.Set(secondaryEntityType).Find(row[secondaryKeyName]);
                                var secondaryEntityEntry = context.Entry(secondaryEntity);

                                //ValidateOriginalValues(secondaryEntityEntry, row, secondaryKeyName);
                                ValidateEditDate(primaryEntityEntry, primaryDataRow);

                                SetCurrentValues(secondaryEntityEntry, row, secondaryKeyName);

                                break;
                            }
                    }
                }
            }
            return primaryEntity;
        }

        private void ValidateEditDate(DbEntityEntry entityEntry, DataRow dataRow)
        {
            var dataRowEditDate = (DateTime)dataRow["Rn_Edit_Date", DataRowVersion.Original];
            var entryEditDate = (DateTime)entityEntry.OriginalValues["Rn_Edit_Date"];

            if(Math.Abs((dataRowEditDate - entryEditDate).Milliseconds) > 1000)
                throw new PivotalApplicationCoreException("Walidacja:Dane zostały zmienione. Proszę odświeżyć rekord");
        }

        private void ValidateOriginalValues(DbEntityEntry entityEntry, DataRow dataRow, string primaryKeyName)
        {
            var columns = dataRow.Table.Columns;
            foreach (var propertyName in entityEntry.OriginalValues.PropertyNames)
            {
                if (propertyName == primaryKeyName || columns[propertyName] == null) continue;

                var dataRowValue = dataRow[propertyName, DataRowVersion.Original];
                dataRowValue = dataRowValue == DBNull.Value ? null : dataRowValue.Equals(true) ? (byte?)1 : dataRowValue.Equals(false) ? (byte?)0 : dataRowValue;

                var propertyValue = entityEntry.OriginalValues[propertyName];

                if(propertyValue != null && dataRowValue == null)
                    throw new PivotalApplicationCoreException("Walidacja:Dane zostały zmienione. Proszę odświeżyć rekord");

                if (columns[propertyName] != null && propertyValue != null && dataRowValue != null && 
                    !propertyValue.Equals(dataRowValue))
                {
                    if (propertyName == "Rn_Descriptor")
                        continue;

                    var type = dataRowValue.GetType();
                    if (type.Equals(typeof(DateTime?)) || type.Equals(typeof(DateTime)))
                    {
                        var timeSpan = ((DateTime?)dataRowValue - (entityEntry.OriginalValues[propertyName] as DateTime?));
                        if (timeSpan.HasValue && Math.Abs(timeSpan.Value.Milliseconds) < 1000) continue;
                    }
                    if (type.Equals(typeof(byte[])) && (dataRowValue as byte[]).SequenceEqual((byte[])entityEntry.OriginalValues[propertyName]))
                    {
                        continue;
                    }                    
                    throw new PivotalApplicationCoreException("Walidacja:Dane zostały zmienione. Proszę odświeżyć rekord");
                }
            }
        }

        private void SetCurrentValues(DbEntityEntry entityEntry, DataRow dataRow, string primaryKeyName)
        {
            var columns = dataRow.Table.Columns;
            foreach (var propertyName in entityEntry.CurrentValues.PropertyNames)
            {
                if (propertyName == primaryKeyName || columns[propertyName] == null) continue;

                var dataRowValue = dataRow[propertyName];
                dataRowValue = dataRowValue == DBNull.Value ? null : dataRowValue.Equals(true) ? (byte?)1 : dataRowValue.Equals(false) ? (byte?)0 : dataRowValue;
                entityEntry.CurrentValues[propertyName] = dataRowValue;
            }
        }

        protected virtual void SaveData(Entities context, object primaryEntity)
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                var entryIsProxy = entry.GetType().Namespace == "System.Data.Entity.DynamicProxies";

                if (entry.State == EntityState.Added)
                    SetRnColumns(entry, true, entryIsProxy ? entry.GetType().BaseType.Name : entry.GetType().Name);
                else if (entry.State == EntityState.Modified)
                    SetRnColumns(entry, false, entryIsProxy ? entry.GetType().BaseType.Name : entry.GetType().Name);
            }
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                var log = new DiagnosticLog();
                log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.SaveData.DBUpdateException", $"[{e.InnerException}]");
                throw;
            }
            catch (DbEntityValidationException e)
            {
                var log = new DiagnosticLog();
                foreach (var eve in e.EntityValidationErrors)
                {
                    log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.SaveData.DbEntityValidationException", string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.SaveData.DbEntityValidationException", string.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                throw;
            }
            catch (Exception e)
            {
                var log = new DiagnosticLog();
                log.WriteLog(SystemServer, LogLevel.ERROR, "ContextFormTask.SaveData.Exception", $"[{e.ToString()}][{e.InnerException}]");
                throw;
            }
        }

        protected override DataSet LoadData(DataTemplate template, Id rowId, ParameterList parameters)
        {
            try
            {
                TransitionPointParameter.ParameterList = parameters;                

                DataSet dataSet = SystemServer.DataService.LoadDataDirect(template, rowId, parameters);

                using (var context = GetContext())
                {
                    LoadData(context, dataSet, template);
                }

                TransitionPointParameter.CopyToParameterList(parameters);

                return dataSet;
            }
            catch (Exception e)
            {
                throw new PivotalApplicationCoreException(e.Message, e);
            }
        }

        protected virtual void LoadData(Entities context, DataSet dataSet, DataTemplate template)
        {
            
        }

        protected override void DeleteData(DataTemplate template, Id rowId, ParameterList parameters)
        {
            try
            {
                TransitionPointParameter.ParameterList = parameters;

                using (var context = GetContext())
                {
                    var primaryEntity = SeedContextDelete(template, rowId, context);
                    DeleteData(context, primaryEntity);
                }

                TransitionPointParameter.CopyToParameterList(parameters);
            }
            catch (Exception e)
            {
                throw new PivotalApplicationCoreException(e.Message, e);
            }
        }

        private object SeedContextDelete(DataTemplate dataTemplate, Id objectId, Entities context)
        {
            var primaryTableName = dataTemplate.PrimaryDataSection.Table.Name;
            var primaryEntityType = ModelEntities.Single(t => t.Name == primaryTableName);
            return context.Set(primaryEntityType).Find(objectId.ToByteArray());
        }

        protected virtual void DeleteData(Entities context, object primaryEntity)
        {
            context.Set(primaryEntity.GetType()).Remove(primaryEntity);
            context.SaveChanges();
        }

        private Entities GetContext()
        {
            string edmxConnectionString = $@"metadata=res://*/EdModel.csdl|res://*/EdModel.ssdl|res://*/EdModel.msl;provider=System.Data.SqlClient;provider connection string=""{SystemServer.DatabaseInformation.EDConnectionString}; multipleactiveresultsets = True; application name = EntityFramework""";
            if (ContextFactory == null) ContextFactory = new ContextFactory(edmxConnectionString);
            return ContextFactory.GetContext();
        }

        private void SetRnColumns(DbEntityEntry entityEntry, bool addRecord, string tableName)
        {
            var property = entityEntry.Property("Rn_Edit_Date");
            if(property != null) property.CurrentValue = DateTime.Now;

            property = entityEntry.Property("Rn_Edit_User");
            if (property != null) property.CurrentValue = SystemServer.UserProfile.UserId.ToByteArray();

            if (addRecord)
            {
                property = entityEntry.Property("Rn_Create_Date");
                if (property != null) property.CurrentValue = DateTime.Now;

                property = entityEntry.Property("Rn_Create_User");
                if (property != null) property.CurrentValue = SystemServer.UserProfile.UserId.ToByteArray();
            }
        }
    }
}
