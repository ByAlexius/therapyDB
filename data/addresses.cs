//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace therapyDB.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class addresses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public addresses()
        {
            this.locations = new HashSet<locations>();
            this.patients = new HashSet<patients>();
        }
    
        public int add_id { get; set; }
        public string city { get; set; }
        public string postal { get; set; }
        public string street { get; set; }
        public Nullable<int> nr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<locations> locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patients> patients { get; set; }
    }
}
