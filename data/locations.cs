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
    
    public partial class locations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public locations()
        {
            this.rooms = new HashSet<rooms>();
        }
    
        public int loc_id { get; set; }
        public string name { get; set; }
        public int address_id { get; set; }
    
        public virtual addresses addresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rooms> rooms { get; set; }
    }
}
