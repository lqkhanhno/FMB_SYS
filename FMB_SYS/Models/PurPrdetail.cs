using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class PurPrdetail
    {
        public string PrNo { get; set; }
        public string ItemName { get; set; }
        public string SupplierName { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public double? Vat { get; set; }
        public double? Amount { get; set; }
    }
}
