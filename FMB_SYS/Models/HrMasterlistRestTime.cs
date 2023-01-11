using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class HrMasterlistRestTime
    {
        public string ShiftName { get; set; }
        public TimeSpan? RestTime { get; set; }
        public int? PlusMinute { get; set; }
        public int? NumberMinRest { get; set; }
        public int RowId { get; set; }
    }
}
