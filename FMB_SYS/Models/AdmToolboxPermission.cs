using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class AdmToolboxPermission
    {
        public string FrmName { get; set; }
        public string ToolboxName { get; set; }
        public string Username { get; set; }
        public string LastUserCommit { get; set; }
        public DateTime? LastTimeCommit { get; set; }
    }
}
