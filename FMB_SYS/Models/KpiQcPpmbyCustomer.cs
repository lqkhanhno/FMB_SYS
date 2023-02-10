using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiQcPpmbyCustomer
    {
        public DateTime? Date { get; set; }
        public string IncCustomer { get; set; }
        public double? Ppm { get; set; }
    }
}
