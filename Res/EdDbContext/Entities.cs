using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdDbContext
{
    public partial class Entities
    {
        public Entities(string connectionString) : base(connectionString)
        { }        

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries();
            foreach (var grouping in entries
                .Where(e => e.State == EntityState.Added)
                .GroupBy(e => e.Entity.GetType().Namespace == "System.Data.Entity.DynamicProxies" ? e.Entity.GetType().BaseType : e.Entity.GetType()))
            {
                var count = grouping.Count();
                var lastId = UpdateLastId(grouping.Key.Name,
                    count);
                int i = 1;
                foreach (var entity in grouping)
                {                  
                    CheckEntityPrimaryKey(entity, ref i, lastId);
                }
            };

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            foreach (var grouping in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added)
                .GroupBy(e => e.Entity.GetType().Namespace == "System.Data.Entity.DynamicProxies" ? e.Entity.GetType().BaseType : e.Entity.GetType()))
            {
                var count = grouping.Count();
                var lastId = UpdateLastId(grouping.Key.Namespace == "System.Data.Entity.DynamicProxies" ?
                    grouping.Key.BaseType.Name : grouping.Key.Name,
                    count);
                foreach (var entity in grouping)
                {
                    int i = 1;
                    CheckEntityPrimaryKey(entity, ref i, lastId);
                }
            };
            return base.SaveChangesAsync();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            foreach (var grouping in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added)
                .GroupBy(e => e.Entity.GetType().Namespace == "System.Data.Entity.DynamicProxies" ? e.Entity.GetType().BaseType : e.Entity.GetType()))
            {
                var count = grouping.Count();
                var lastId = UpdateLastId(grouping.Key.Name,
                    count);
                foreach (var entity in grouping)
                {
                    int i = 1;
                    CheckEntityPrimaryKey(entity, ref i, lastId);
                }
            };
            return base.SaveChangesAsync(cancellationToken);
        }

        private void CheckEntityPrimaryKey(DbEntityEntry entry, ref int increase, byte[] lastId)
        {
            object entity = entry.Entity;
            var entityType = entity.GetType();
            var tableName = entityType.Namespace == "System.Data.Entity.DynamicProxies" ? entityType.BaseType.Name : entityType.Name;
            var primaryKeyProp = entityType.
                GetProperty(tableName + "_Id",
                    System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            if (null != primaryKeyProp && primaryKeyProp.CanWrite)
            {
                var primaryKeyValue = primaryKeyProp.GetValue(entity);
                if (primaryKeyValue != null && primaryKeyValue != DBNull.Value)
                {
                    entry.State = EntityState.Modified;
                }
                else
                {
                    primaryKeyProp.SetValue(entity, IdIncreaser(lastId, increase++));
                }
            }
            else throw new InvalidOperationException($"Primary key cannot be found by convention. " +
                $"Missing key name: {tableName + "_Id"} for entity from table: {tableName}");
        }

        private byte[] UpdateLastId(string tableName, int addCount)
        {
            var lastIdEntry = RSys_Last_Id.First(e => e.Table_Name == tableName);
            var lastId = lastIdEntry.Last_Id_Value;
            lastIdEntry.Last_Id_Value = IdIncreaser(lastId, addCount);
            return lastId;           
        }

        private byte[] IdIncreaser(byte[] lastId, int increase)
        {
            byte[] result = new byte[8];
            int length = lastId.Length;
            if (length > 8) return result;
            else if (length < 8) lastId.CopyTo(result, 8 - length);
            else result = lastId;
            long newId = BitConverter.ToInt64(result.Reverse().ToArray(), 0) + increase;
            return BitConverter.GetBytes(newId).Reverse().ToArray();
        }        
    }
}
