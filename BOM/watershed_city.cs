//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOM
{
    using System;
    using System.Collections.Generic;
    
    public partial class watershed_city
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public watershed_city()
        {
            this.watershed_city_data = new HashSet<watershed_city_data>();
            this.watershed_taluka = new HashSet<watershed_taluka>();
        }
    
        public int cid { get; set; }
        public string cname { get; set; }
        public int sid { get; set; }
        public double area { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<watershed_city_data> watershed_city_data { get; set; }
        public virtual watershed_state watershed_state { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<watershed_taluka> watershed_taluka { get; set; }
    }
}
