using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class LogInvoice
    {
        public string InvoiceNo { get; set; }
        public string TruckNo { get; set; }
        public string LastUserCommit { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public DateTime? ShipDate { get; set; }
    }
}
