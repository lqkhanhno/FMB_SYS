using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class PMasterListScanner
    {
        public string ScannerId { get; set; }
        public string ScannerName { get; set; }
        public string Department { get; set; }
        public string Des1 { get; set; }
        public string Des2 { get; set; }
        public string Des3 { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string LastUserCommit { get; set; }
    }
}
