using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class KpiMaintEnergyDetail
    {
        public DateTime? Date { get; set; }
        public double? MixingKwh { get; set; }
        public double? MixingCost { get; set; }
        public double? Baekwh { get; set; }
        public double? Baecost { get; set; }
        public double? Ovkwh { get; set; }
        public double? Ovcost { get; set; }
        public double? Pfkwh { get; set; }
        public double? Pfcost { get; set; }
        public double? OfficeKwh { get; set; }
        public double? OffceCost { get; set; }
        public double? Spkwh { get; set; }
        public double? Spcost { get; set; }
    }
}
