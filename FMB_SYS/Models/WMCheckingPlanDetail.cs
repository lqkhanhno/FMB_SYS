using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class WMCheckingPlanDetail
    {
        public string RmPlanId { get; set; }
        public string MName { get; set; }
        public double? Quantity { get; set; }
        public string PShift { get; set; }
        public string PlanType { get; set; }
    }
}
