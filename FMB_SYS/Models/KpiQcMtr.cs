using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiQcMtr
    {
        public DateTime? Date { get; set; }
        public double? MtrDaily { get; set; }
        public double? MtrCumul { get; set; }
        public double? MtrCumulExceptCuttingBit { get; set; }
        public double? Target { get; set; }
        public double? ScrapWeight { get; set; }
        public double? TotalWeight { get; set; }
    }
}
