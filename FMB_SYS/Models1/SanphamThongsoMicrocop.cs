using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class SanphamThongsoMicrocop
    {
        public int Id { get; set; }
        public int? IdspthongSo { get; set; }
        public string Item { get; set; }
        public double? TieuChuan { get; set; }
        public double? Min { get; set; }
        public double? Max { get; set; }
        public double? ThucTe { get; set; }
        public double? DoDaiMau { get; set; }
    }
}
