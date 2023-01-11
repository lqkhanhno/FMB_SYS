using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class KpiPdEfficiency
    {
        public DateTime? Date { get; set; }
        public double? StandardHours { get; set; }
        public double? ActualHours { get; set; }
        public double? DailyEfficiency { get; set; }
        public double? CulmulEfficiency { get; set; }
        public double? StandardHoursNew { get; set; }
        public double? DailyEfficiencyNew { get; set; }
        public double? CulmulEfficiencyNew { get; set; }
    }
}
