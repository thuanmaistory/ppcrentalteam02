//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.FrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class STREET_TABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STREET_TABLE()
        {
            this.PROJECT_TABLE = new HashSet<PROJECT_TABLE>();
        }
    
        public int id { get; set; }
        public string StreetName { get; set; }
        public int District_ID { get; set; }
        public bool Status { get; set; }
    
        public virtual DISCTRICT_TABLE DISCTRICT_TABLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT_TABLE> PROJECT_TABLE { get; set; }
    }
}
