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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    public partial class watershed_taluka_data
    {
        [Display(Name = "Taluka Id.")]
        public int tal_id { get; set; }
        [Display(Name = "Population")]
        public int population { get; set; }
        [Display(Name = "WaterRequired.")]
        public double waterreq { get; set; }
        [Display(Name = "Rainfall")]
        public double rainfall { get; set; }
        [Display(Name = "Wateravailable")]
        public double wateravail { get; set; }
        [Display(Name = "Water sarcacity")][Required]
        public double water_sarcacity { get; set; }
        [Display(Name = "Year")][Required]
        public System.DateTime cycle_year { get; set; }
        public int td_id { get; set; }
    
        public virtual watershed_taluka watershed_taluka { get; set; }
    }
}
