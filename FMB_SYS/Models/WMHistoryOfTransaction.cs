using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class WMHistoryOfTransaction
    {
        public string WhmrCode { get; set; }
        public string MName { get; set; }
        public double? Quantity { get; set; }
        public string LotNo { get; set; }
        public string Transaction { get; set; }
        public string Location { get; set; }
        public DateTime? InputTime { get; set; }
        public string Pic { get; set; }
        public string InvoiceNo { get; set; }
        public string TruckNo { get; set; }
        public string PlanNo { get; set; }
        public string Place { get; set; }
        public string WhmiCode { get; set; }
        public string MNote { get; set; }
    }
}
