using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class WMIssueDoc
    {
        public string MDocId { get; set; }
        public string LastUserCommit { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string MDocStatus { get; set; }
        public DateTime? MDocCompleteTime { get; set; }
        public DateTime? MDocSupplyDate { get; set; }
    }
}
