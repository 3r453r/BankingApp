//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Employee_Skills
    {
        public byte[] Employee_Skills_Id { get; set; }
        public string Rn_Descriptor { get; set; }
        public Nullable<System.DateTime> Rn_Create_Date { get; set; }
        public byte[] Rn_Create_User { get; set; }
        public Nullable<System.DateTime> Rn_Edit_Date { get; set; }
        public byte[] Rn_Edit_User { get; set; }
        public byte[] A_WFlow_Template_Conf_Id { get; set; }
        public Nullable<byte> Dodatkowa_Kontrola { get; set; }
        public byte[] Employee_Id { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
