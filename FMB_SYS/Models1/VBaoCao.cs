using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class VBaoCao
    {
        public DateTime? ThoiGian { get; set; }
        public string TenCn { get; set; }
        public string LoaiSp { get; set; }
        public string HinhAnh { get; set; }
        public string MaSp { get; set; }
        public double? SpKichThuocChatGhtren { get; set; }
        public double? SpKichThuocLayMau { get; set; }
        public double? SpThoiGianLayMau { get; set; }
        public bool? ApSuat { get; set; }
        public string KindofNumber { get; set; }
        public int? IdspthongSo { get; set; }
        public double? ĐộDầyLớpTrong { get; set; }
        public double? ĐộDầyLớpNgoài { get; set; }
        public double? ChiềuDầyTổng { get; set; }
        public double? ĐườngKínhTrong { get; set; }
        public double? ĐườngKínhNgoài { get; set; }
        public double? TenlsiO { get; set; }
        public double? ReometerO { get; set; }
        public double? FmbO { get; set; }
        public double? CmbO { get; set; }
        public double? CmbI { get; set; }
        public double? FmbI { get; set; }
        public double? ReometerI { get; set; }
        public double? TenlsiI { get; set; }
        public string Ca { get; set; }
    }
}
