using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class WMIssueLabel
    {
        public string WhmiCode { get; set; }
        public string MName { get; set; }
        public string ProductCustomerCode { get; set; }
        public double? Quantity { get; set; }
        public DateTime? LotNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public string PShift { get; set; }
        public string PLine { get; set; }
        public double? Weight { get; set; }
        public DateTime? SupplyDate { get; set; }
        public string MDocId { get; set; }
        public string WhmrCode { get; set; }
    }
}
