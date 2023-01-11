using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class MMonitorIssue
    {
        public string IssueId { get; set; }
        public string IssueName { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string Status { get; set; }
    }
}
