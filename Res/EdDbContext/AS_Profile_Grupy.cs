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
    
    public partial class AS_Profile_Grupy
    {
        public byte[] AS_Profile_Uprawnienia_Id { get; set; }
        public byte[] AV_BM_Group_Id { get; set; }
        public byte[] AS_Profile_Grupy_Id { get; set; }
        public string Rn_Descriptor { get; set; }
        public Nullable<System.DateTime> Rn_Create_Date { get; set; }
        public byte[] Rn_Create_User { get; set; }
        public Nullable<System.DateTime> Rn_Edit_Date { get; set; }
        public byte[] Rn_Edit_User { get; set; }
    
        public virtual AS_Profile_Uprawnienia AS_Profile_Uprawnienia { get; set; }
        public virtual AV_BM_Group AV_BM_Group { get; set; }
    }
}