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
    
    public partial class AV_BM_Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AV_BM_Group()
        {
            this.AS_Profile_Grupy = new HashSet<AS_Profile_Grupy>();
        }
    
        public byte[] AV_BM_Group_Id { get; set; }
        public string Rn_Descriptor { get; set; }
        public System.DateTime Rn_Create_Date { get; set; }
        public byte[] Rn_Create_User { get; set; }
        public System.DateTime Rn_Edit_Date { get; set; }
        public byte[] Rn_Edit_User { get; set; }
        public string PP_CUSTOMER { get; set; }
        public string GroupName { get; set; }
        public string UniqName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AS_Profile_Grupy> AS_Profile_Grupy { get; set; }
    }
}
