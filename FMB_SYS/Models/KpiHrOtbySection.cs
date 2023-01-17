using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiHrOtbySection
    {
        public DateTime? Date { get; set; }
        public string Section { get; set; }
        public double? OtHours { get; set; }
    }
}
