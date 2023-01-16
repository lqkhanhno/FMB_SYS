using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class KpiQcPpmbyCustomer
    {
        public DateTime? Date { get; set; }
        public string IncCustomer { get; set; }
        public double? Ppm { get; set; }
    }
}
