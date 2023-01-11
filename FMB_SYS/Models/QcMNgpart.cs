using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class QcMNgpart
    {
        public string WhmrCode { get; set; }
        public string MName { get; set; }
        public DateTime? LotNo { get; set; }
        public double? Quantity { get; set; }
        public string PicQc { get; set; }
        public DateTime? TimeQcCheck { get; set; }
        public double? NgScratch { get; set; }
        public double? NgBurr { get; set; }
        public double? NgRust { get; set; }
        public double? NgOthers { get; set; }
        public double? NgWrongDimension { get; set; }
        public double? NgWrongShape { get; set; }
        public double? NgElectricFail { get; set; }
        public double? WhmrCodeOrigin { get; set; }
    }
}
