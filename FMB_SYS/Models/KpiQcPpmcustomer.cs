using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiQcPpmcustomer
    {
        public DateTime? Date { get; set; }
        public string CustomerName { get; set; }
        public double? ClaimQty { get; set; }
        public double? ShippingQty { get; set; }
        public string ClaimContent { get; set; }
    }
}
