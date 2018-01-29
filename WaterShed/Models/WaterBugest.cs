using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaterShed.Models
{
    public class WaterBugest
    {
        public double Toilet { get; set; }
        public double Bath { get; set; }
        public double clothwashing { get; set; }
        public double dishwashing { get; set; }
        public double livestock { get; set; }
        public double total { get; set; }
     
    }
}