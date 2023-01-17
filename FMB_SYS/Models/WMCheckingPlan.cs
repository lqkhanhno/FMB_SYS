using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class WMCheckingPlan
    {
        public string RmPlanId { get; set; }
        public DateTime? CheckDate { get; set; }
        public string LastUserCommit { get; set; }
        public DateTime? LastTimeCommit { get; set; }
    }
}
