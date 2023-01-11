using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class WCycleCount
    {
        public string CcName { get; set; }
        public DateTime? CcDate { get; set; }
        public string CcType { get; set; }
        public string CcDes { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string LastUserCommit { get; set; }
        public bool? IsActive { get; set; }
        public string IsLock { get; set; }
        public string IsConfirm { get; set; }
    }
}
