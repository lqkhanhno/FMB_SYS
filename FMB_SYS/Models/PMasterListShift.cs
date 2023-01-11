using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class PMasterListShift
    {
        public string ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public double? PlusHourStart { get; set; }
        public TimeSpan? EndTime { get; set; }
        public double? PlusHourEnd { get; set; }
    }
}
