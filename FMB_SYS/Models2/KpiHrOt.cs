using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class KpiHrOt
    {
        public DateTime? Date { get; set; }
        public double? TargetOt { get; set; }
        public double? CumulTargetOt { get; set; }
        public double? Ot { get; set; }
        public double? CumulOt { get; set; }
        public double? OtNormal { get; set; }
        public double? CumulOtNormal { get; set; }
        public double? OtAbnormal { get; set; }
        public double? CumulOtAbnormal { get; set; }
        public double? OtIndirect { get; set; }
        public double? OtDirect { get; set; }
        public double? Color { get; set; }
        public double? OtAmountIndirect { get; set; }
        public double? OtAmountDirect { get; set; }
        public double? OtPercentIndirect { get; set; }
        public double? OtPercentDirect { get; set; }
    }
}
