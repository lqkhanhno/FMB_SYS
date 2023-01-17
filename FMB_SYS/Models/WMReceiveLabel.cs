using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class WMReceiveLabel
    {
        public string WhmrCode { get; set; }
        public string MName { get; set; }
        public double? Quantity { get; set; }
        public DateTime? LotNo { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreatedUser { get; set; }
        public string RmDocId { get; set; }
        public string WhOp { get; set; }
        public DateTime? WhReceiveTime { get; set; }
        public string WhOkng { get; set; }
        public string TruckNo { get; set; }
        public string Place { get; set; }
        public string PicIssueQc { get; set; }
        public DateTime? TimeIssueQc { get; set; }
        public string RmPlanId { get; set; }
        public string QcOkng { get; set; }
        public string PicQc { get; set; }
        public DateTime? TimeQcCheck { get; set; }
        public string WhLocation { get; set; }
        public string OpLocate { get; set; }
        public DateTime? LocateTime { get; set; }
        public string WhmrCodeOrigin { get; set; }
        public string PicIssuePd { get; set; }
        public DateTime? TimeIssuePd { get; set; }
        public string PicReturnPd { get; set; }
        public DateTime? TimeReturnPd { get; set; }
    }
}
