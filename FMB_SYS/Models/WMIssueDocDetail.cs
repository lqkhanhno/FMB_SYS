using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class WMIssueDocDetail
    {
        public string MDocId { get; set; }
        public string MName { get; set; }
        public string ProductCustomerCode { get; set; }
        public double? MDemand { get; set; }
        public string PLine { get; set; }
        public string PShift { get; set; }
    }
}
