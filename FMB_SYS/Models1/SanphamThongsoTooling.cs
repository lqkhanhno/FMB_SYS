using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class SanphamThongsoTooling
    {
        public int Id { get; set; }
        public int? IdspthongSo { get; set; }
        public double? Type1 { get; set; }
        public double? Type2 { get; set; }
        public double? KhuonKichThuoc1 { get; set; }
        public double? KhuonKichThuoc2 { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string Type { get; set; }
        public string KichThuocKhuon { get; set; }
    }
}
