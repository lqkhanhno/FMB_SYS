using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class ViewKpiLogSale
    {
        public DateTime? Date { get; set; }
        public decimal? DailySales { get; set; }
        public decimal? SaleCumul { get; set; }
        public decimal? SaleTarget { get; set; }
    }
}
