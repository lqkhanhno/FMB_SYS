using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiQcPpmincoming
    {
        public DateTime? Date { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string PartNumber { get; set; }
        public double? Actual { get; set; }
        public double? NotOk { get; set; }
    }
}
