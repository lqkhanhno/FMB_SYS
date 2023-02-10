using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class AdmLogActivity
    {
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string LastTimeCommit { get; set; }
        public string Action { get; set; }
    }
}
