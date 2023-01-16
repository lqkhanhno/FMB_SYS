using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class AdmDocument
    {
        public int DocId { get; set; }
        public string DocKind { get; set; }
        public string DocContent { get; set; }
        public string DocLink { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? TimeCommit { get; set; }
        public string DocNote { get; set; }
    }
}
