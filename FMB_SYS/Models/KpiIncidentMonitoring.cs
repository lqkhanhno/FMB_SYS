using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiIncidentMonitoring
    {
        public int CheckId { get; set; }
        public string IncName { get; set; }
        public string IncType { get; set; }
        public string IncTheme { get; set; }
        public string IncDes { get; set; }
        public string IncLevel { get; set; }
        public string Author { get; set; }
        public string Location { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? CreatedFor { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string IsAction { get; set; }
        public string LastUserCommit { get; set; }
        public string Is8D { get; set; }
        public string IncStatus { get; set; }
        public string IncCustomer { get; set; }
        public double? SortTime { get; set; }
        public double? Cost { get; set; }
    }
}
