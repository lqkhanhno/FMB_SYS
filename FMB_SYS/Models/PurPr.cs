using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class PurPr
    {
        public string PrNo { get; set; }
        public DateTime? PrDate { get; set; }
        public DateTime? EstimateReceivedDate { get; set; }
        public string PrContent { get; set; }
        public string PrType { get; set; }
        public string Requester { get; set; }
        public string Dept { get; set; }
        public double? Amount { get; set; }
        public double? AmountWithVat { get; set; }
        public string Unit { get; set; }
        public string Checker { get; set; }
        public DateTime? CheckDate { get; set; }
        public string Approver { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string IsActive { get; set; }
    }
}
