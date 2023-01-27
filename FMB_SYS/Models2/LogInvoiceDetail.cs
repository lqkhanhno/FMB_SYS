using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class LogInvoiceDetail
    {
        public string InvoiceNo { get; set; }
        public string ProductCustomerCode { get; set; }
        public string HsCode { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public string Unit { get; set; }
    }
}
