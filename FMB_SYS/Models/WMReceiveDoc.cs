using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class WMReceiveDoc
    {
        public string RmDocId { get; set; }
        public string Supplier { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string LastUserCommit { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string RmDocLink { get; set; }
        public string RmDocLink2 { get; set; }
        public string RmDocLink3 { get; set; }
        public string TruckNo { get; set; }
        public string RmDocName { get; set; }
        public string RmDocName2 { get; set; }
        public string RmDocName3 { get; set; }
    }
}
