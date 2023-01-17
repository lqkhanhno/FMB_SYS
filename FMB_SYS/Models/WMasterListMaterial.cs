using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class WMasterListMaterial
    {
        public string MName { get; set; }
        public string IsActive { get; set; }
        public string MDes { get; set; }
        public double? RawQty { get; set; }
        public double? RawWeight { get; set; }
        public double? MQty { get; set; }
        public string ScaleType { get; set; }
    }
}
