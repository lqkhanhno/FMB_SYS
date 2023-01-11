using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class KpiActionMonitoring
    {
        public int CheckId { get; set; }
        public string ActName { get; set; }
        public string ActDes { get; set; }
        public string IncName { get; set; }
        public string Priority { get; set; }
        public DateTime? PlannedFor { get; set; }
        public string AssignedUser { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUserCommit { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string Theme { get; set; }
    }
}
