using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class AdmDurationControl
    {
        public string ParentName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? ValuesNumber { get; set; }
        public string ValuesString { get; set; }
    }
}
