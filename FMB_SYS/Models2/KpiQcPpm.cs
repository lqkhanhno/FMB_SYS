using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class KpiQcPpm
    {
        public DateTime? Date { get; set; }
        public int? Ppm { get; set; }
        public int? PpmCumul { get; set; }
        public int? Target { get; set; }
    }
}
