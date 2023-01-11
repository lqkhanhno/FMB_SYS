using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class TempCurrentProductionFg
    {
        public DateTime? PlanDate { get; set; }
        public string Shift { get; set; }
        public string LineNo { get; set; }
        public string ProductCode { get; set; }
        public string CustomerProductCode { get; set; }
        public int? NumberOperator { get; set; }
        public int? Target { get; set; }
        public int? PlanTarget { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StartTimeEstimate { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime? FinishTimeEstimate { get; set; }
        public int? Quantity { get; set; }
        public double? Mps { get; set; }
        public double? Efficiency { get; set; }
        public double? StardardTimeFg { get; set; }
    }
}
