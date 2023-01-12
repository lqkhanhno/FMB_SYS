using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class Kehoachsanxuat
    {
        public int Id { get; set; }
        public int? IdspthongSo { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? Sl { get; set; }
        public bool? KhongChat { get; set; }
        public int? Ca { get; set; }
        public string GhiChu { get; set; }
        public byte TrangThai { get; set; }
        public int? InnerCode1 { get; set; }
        public int? InnerCode2 { get; set; }
        public int? InnerCode3 { get; set; }
        public int? OuterCode1 { get; set; }
        public int? OuterCode2 { get; set; }
    }
}
