using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiLogSale
    {
        public DateTime? Date { get; set; }
        public string Project { get; set; }
        public double? Sale { get; set; }
        public double? SaleCumul { get; set; }
        public double? SaleTarget { get; set; }
    }
}
