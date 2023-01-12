using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class SanphamThongsoNhietdosoidot
    {
        public int Id { get; set; }
        public int? IdspthongSo { get; set; }
        public string ViTri { get; set; }
        public double? NhietDoCaiDat { get; set; }
        public double? GioiHan { get; set; }
        public double? GioiHanDungSoiDot { get; set; }
    }
}
