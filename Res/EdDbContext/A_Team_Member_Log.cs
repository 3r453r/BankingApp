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
    
    public partial class A_Team_Member_Log
    {
        public byte[] A_Team_Member_Id { get; set; }
        public Nullable<byte> Rec_Operation { get; set; }
        public byte[] Employee_Id { get; set; }
        public byte[] A_Team_Id { get; set; }
        public Nullable<byte> Active { get; set; }
        public Nullable<byte> Coordinator { get; set; }
        public byte[] A_Team_Member_Log_Id { get; set; }
        public string Rn_Descriptor { get; set; }
        public Nullable<System.DateTime> Rn_Create_Date { get; set; }
        public byte[] Rn_Create_User { get; set; }
        public Nullable<System.DateTime> Rn_Edit_Date { get; set; }
        public byte[] Rn_Edit_User { get; set; }
    }
}
