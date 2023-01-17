using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiMaintElectricity
    {
        public DateTime? Date { get; set; }
        public double? Actual { get; set; }
        public double? Cost { get; set; }
    }
}
