using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class TempWMIssueToQc
    {
        public string WhmrCode { get; set; }
        public string MName { get; set; }
        public double? Quantity { get; set; }
        public string WhOp { get; set; }
        public DateTime? WhIssueTime { get; set; }
        public string Transaction { get; set; }
        public string Place { get; set; }
        public string IsCheck { get; set; }
        public string RmPlanId { get; set; }
        public string QcShift { get; set; }
    }
}
