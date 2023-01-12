using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class SanphamThongso
    {
        public int Id { get; set; }
        public string MaSp { get; set; }
        public double? DunTrongTieuChuan { get; set; }
        public double? DunTrongMin { get; set; }
        public double? DunTrongMax { get; set; }
        public double? DunTrongSafety { get; set; }
        public double? DunNgoaiTieuChuan { get; set; }
        public double? DunNgoaiMin { get; set; }
        public double? DunNgoaiMax { get; set; }
        public double? DunNgoaiSafety { get; set; }
        public double? ZumbachTieuChuan { get; set; }
        public double? ZumbachMin { get; set; }
        public double? ZumbachMax { get; set; }
        public double? SpKichThuocChatTieuChuan { get; set; }
        public double? SpKichThuocChatGhtren { get; set; }
        public double? SpKichThuocLayMau { get; set; }
        public double? SpThoiGianLayMau { get; set; }
        public bool? ApSuat { get; set; }
        public string TenCn { get; set; }
        public bool? Run { get; set; }
        public bool? CheckTooling { get; set; }
        public bool? CheckBarcode { get; set; }
        public bool? KqMicrocop { get; set; }
        public string HinhAnh { get; set; }
        public double? Sl { get; set; }
        public DateTime? ThoiGianHinhAnh { get; set; }
        public int? SlSanPham { get; set; }
        public double? AtmBeNuocNgoai { get; set; }
        public double? AtmBeNuocTrong { get; set; }
        public bool? KhongChat { get; set; }
        public int? IdnlInner { get; set; }
        public int? IdnlOuter { get; set; }
        public bool? Xe1 { get; set; }
        public bool? Xe2 { get; set; }
        public bool? Xe3 { get; set; }
        public bool? Xe4 { get; set; }
        public bool? Xe5 { get; set; }
        public int? ThoiGianHieuChinh { get; set; }
        public double? SpKhoiluongPh { get; set; }
        public double? SpKhoiluongdaiPh { get; set; }
    }
}
