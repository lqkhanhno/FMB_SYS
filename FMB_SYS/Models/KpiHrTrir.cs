using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiHrTrir
    {
        public DateTime Date { get; set; }
        public double? Death { get; set; }
        public double? LostTime { get; set; }
        public double? NoLostTime { get; set; }
        public double? FirstAids { get; set; }
        public double? NearMisses { get; set; }
        public double? Risky { get; set; }
    }
}
