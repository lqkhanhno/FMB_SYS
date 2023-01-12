using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class Barcode
    {
        public int Id { get; set; }
        public DateTime? NgayCan { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? IdspthongSo { get; set; }
        public int? IdNl { get; set; }
        public DateTime? Lotruber { get; set; }
        public string Idca { get; set; }
        public int? IdloaiSp { get; set; }
        public double? Cmb { get; set; }
        public double? Fmb { get; set; }
        public double? Reometer { get; set; }
        public double? Tenlsi { get; set; }
        public double? TenlsiUts { get; set; }
        public double? TenlsiBelong { get; set; }
        public double? Moisture { get; set; }
        public double? GravityCmb { get; set; }
        public double? KhoiLuong { get; set; }
        public string Kq { get; set; }
        public bool? ByPass { get; set; }
        public bool? Huy { get; set; }
        public string MaCode { get; set; }
        public string MaNguyenLieu { get; set; }
    }
}
