using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class PMasterListProduct
    {
        public string ProductCode { get; set; }
        public string ProductCustomerCode { get; set; }
        public string ProductRev { get; set; }
        public string ProductName { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public decimal? StandardTime { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? StandardTimeFg { get; set; }
        public int? ProductQuantity { get; set; }
        public double? ProductWeight { get; set; }
        public string CartonType { get; set; }
        public int? NumberOperator { get; set; }
        public string ProductLine { get; set; }
        public string CheckType { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string LastUserCommit { get; set; }
        public string LastUserApprove { get; set; }
        public DateTime? LastTimeApprove { get; set; }
        public string Note { get; set; }
        public string HsCode { get; set; }
    }
}
