using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiHrLaborResource
    {
        public DateTime? Date { get; set; }
        public double? Sop { get; set; }
        public double? LaborAndOt { get; set; }
        public double? RealHeadCount { get; set; }
        public double? HcIndirect { get; set; }
        public double? HcDirect { get; set; }
        public double? PltHc { get; set; }
        public double? Absenteeism { get; set; }
        public double? AbsentOff { get; set; }
        public double? AbsentAlCl { get; set; }
        public double? AbsentAbnormal { get; set; }
        public double? AbsentNormal { get; set; }
        public double? Mod { get; set; }
        public double? Moi { get; set; }
        public double? AbsentTarget { get; set; }
        public double? AbsentAbnormalGroup { get; set; }
        public double? CumulLabor { get; set; }
    }
}
