using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class QcFgNgpart
    {
        public string LabelCode { get; set; }
        public string ProductCustomerCode { get; set; }
        public string ProductName { get; set; }
        public double? ProductQuantity { get; set; }
        public DateTime? PlanDate { get; set; }
        public string LotNo { get; set; }
        public string PicQc { get; set; }
        public DateTime? TimeQcCheck { get; set; }
        public double? NgOthers { get; set; }
    }
}
