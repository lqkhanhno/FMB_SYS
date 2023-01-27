using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class WMReceiveDocDetail
    {
        public string RmDocId { get; set; }
        public string MName { get; set; }
        public double? Quantity { get; set; }
        public double? NumberCarton { get; set; }
        public string MLotNo { get; set; }
    }
}
