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
    
    public partial class FEATURE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FEATURE()
        {
            this.PROPERTY_FEATURE = new HashSet<PROPERTY_FEATURE>();
        }
    
        public int ID { get; set; }
        public string FeatureName { get; set; }
        public Nullable<bool> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPERTY_FEATURE> PROPERTY_FEATURE { get; set; }
    }
}
