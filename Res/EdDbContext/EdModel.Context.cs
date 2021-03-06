﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<A_Employee_Profil> A_Employee_Profil { get; set; }
        public virtual DbSet<AS_Profile_Grupy> AS_Profile_Grupy { get; set; }
        public virtual DbSet<AS_Profile_Uprawnienia> AS_Profile_Uprawnienia { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<RSys_Last_Id> RSys_Last_Id { get; set; }
        public virtual DbSet<AV_BM_Group> AV_BM_Group { get; set; }
        public virtual DbSet<A_Employee_Log> A_Employee_Log { get; set; }
        public virtual DbSet<A_Employee_Poswiadczenia_Lg> A_Employee_Poswiadczenia_Lg { get; set; }
        public virtual DbSet<A_Employee_Profil_Log> A_Employee_Profil_Log { get; set; }
        public virtual DbSet<A_GrupaRoboczaPracownika_Lg> A_GrupaRoboczaPracownika_Lg { get; set; }
        public virtual DbSet<A_Team_Member_Log> A_Team_Member_Log { get; set; }
        public virtual DbSet<AS_Profile_Grupy_Log> AS_Profile_Grupy_Log { get; set; }
        public virtual DbSet<AS_Profile_Uprawnienia_Log> AS_Profile_Uprawnienia_Log { get; set; }
        public virtual DbSet<Employee_Skills_Log> Employee_Skills_Log { get; set; }
        public virtual DbSet<A_Employee_Poswiadczenia> A_Employee_Poswiadczenia { get; set; }
        public virtual DbSet<A_Grupa_Robocza_Pracownika> A_Grupa_Robocza_Pracownika { get; set; }
        public virtual DbSet<A_Team_Member> A_Team_Member { get; set; }
        public virtual DbSet<Employee_Skills> Employee_Skills { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<AV_Liczba_Licencji> AV_Liczba_Licencji { get; set; }
        public virtual DbSet<AS_Wlasciciel_Licencji> AS_Wlasciciel_Licencji { get; set; }
        public virtual DbSet<AV_Roznice_Uprawnienia> AV_Roznice_Uprawnienia { get; set; }
        public virtual DbSet<A_Wniosek_Wideo> A_Wniosek_Wideo { get; set; }
        public virtual DbSet<A_Wniosek_Wideo_Krok> A_Wniosek_Wideo_Krok { get; set; }
        public virtual DbSet<A_Case_Process> A_Case_Process { get; set; }
    
        public virtual int A_PIV_Security_ApplyProfiles(byte[] employeeId, byte[] editUserId)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(byte[]));
    
            var editUserIdParameter = editUserId != null ?
                new ObjectParameter("EditUserId", editUserId) :
                new ObjectParameter("EditUserId", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("A_PIV_Security_ApplyProfiles", employeeIdParameter, editUserIdParameter);
        }
    
        public virtual ObjectResult<string> A_PIV_Security_UpdateEmployeesWithProfile(byte[] aSProfileUprawnieniaId, byte[] editUserId)
        {
            var aSProfileUprawnieniaIdParameter = aSProfileUprawnieniaId != null ?
                new ObjectParameter("ASProfileUprawnieniaId", aSProfileUprawnieniaId) :
                new ObjectParameter("ASProfileUprawnieniaId", typeof(byte[]));
    
            var editUserIdParameter = editUserId != null ?
                new ObjectParameter("EditUserId", editUserId) :
                new ObjectParameter("EditUserId", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("A_PIV_Security_UpdateEmployeesWithProfile", aSProfileUprawnieniaIdParameter, editUserIdParameter);
        }
    
        public virtual ObjectResult<A_PIV_Security_GetEmployeeChangelog_Result> A_PIV_Security_GetEmployeeChangelog(byte[] employeeId)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<A_PIV_Security_GetEmployeeChangelog_Result>("A_PIV_Security_GetEmployeeChangelog", employeeIdParameter);
        }
    
        public virtual ObjectResult<A_PIV_Security_GetEmployeeUprawnieniaChangelog_Result> A_PIV_Security_GetEmployeeUprawnieniaChangelog(byte[] employeeId)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<A_PIV_Security_GetEmployeeUprawnieniaChangelog_Result>("A_PIV_Security_GetEmployeeUprawnieniaChangelog", employeeIdParameter);
        }
    
        public virtual ObjectResult<A_PIV_Security_GetProfileUprawnieniaChangelog_Result> A_PIV_Security_GetProfileUprawnieniaChangelog(byte[] aS_Profile_Uprawnienia_Id)
        {
            var aS_Profile_Uprawnienia_IdParameter = aS_Profile_Uprawnienia_Id != null ?
                new ObjectParameter("AS_Profile_Uprawnienia_Id", aS_Profile_Uprawnienia_Id) :
                new ObjectParameter("AS_Profile_Uprawnienia_Id", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<A_PIV_Security_GetProfileUprawnieniaChangelog_Result>("A_PIV_Security_GetProfileUprawnieniaChangelog", aS_Profile_Uprawnienia_IdParameter);
        }
    }
}
