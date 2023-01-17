using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class PlPlanFg
    {
        public DateTime? PlanDate { get; set; }
        public string Shift { get; set; }
        public string LineNo { get; set; }
        public string ProductCode { get; set; }
        public string CustomerProductCode { get; set; }
        public string IsPrint { get; set; }
        public int? NumberOperator { get; set; }
        public int? Target { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Priority { get; set; }
        public string Note { get; set; }
        public int CheckId { get; set; }
        public string IssueMaterial { get; set; }
    }
}
