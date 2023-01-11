using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class TempWMReceiving
    {
        public string WhmrCode { get; set; }
        public string MName { get; set; }
        public double? Quantity { get; set; }
        public string LotNo { get; set; }
        public string RmDocId { get; set; }
        public string WhOp { get; set; }
        public DateTime? WhReceiveTime { get; set; }
        public string WhOkng { get; set; }
        public string TruckNo { get; set; }
        public string Place { get; set; }
        public string Transaction { get; set; }
        public string IsCheck { get; set; }
    }
}
