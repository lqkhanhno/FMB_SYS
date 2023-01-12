using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class DlThucte
    {
        public long Id { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string HinhThuc { get; set; }
        public int? IdspthongSo { get; set; }
        public string TenCn { get; set; }
        public string MaSp { get; set; }
        public double? DunTrongMin { get; set; }
        public double? DunTrongMax { get; set; }
        public double? AtmDauTrucTrong { get; set; }
        public double? DunNgoaiMin { get; set; }
        public double? DunNgoaiMax { get; set; }
        public double? AtmDauTrucNgoai { get; set; }
        public double? ZumbachMin { get; set; }
        public double? ZumbachMax { get; set; }
        public double? DuongkinhZumbachThucte { get; set; }
        public double? TrucVitOSetup { get; set; }
        public double? Truc1OSetup { get; set; }
        public double? Truc2OSetup { get; set; }
        public double? DauMayOSetup { get; set; }
        public double? TrucVitISetup { get; set; }
        public double? Truc1ISetup { get; set; }
        public double? Truc2ISetup { get; set; }
        public double? DauMayISetup { get; set; }
        public double? TrucVitOCr { get; set; }
        public double? Truc1OCr { get; set; }
        public double? Truc2OCr { get; set; }
        public double? DauMayOCr { get; set; }
        public double? TrucVitICr { get; set; }
        public double? Truc1ICr { get; set; }
        public double? Truc2ICr { get; set; }
        public double? DauMayICr { get; set; }
        public double? NhietBeNuoc { get; set; }
        public double? TocDoToi { get; set; }
        public double? TocDoTrucVitDunNgoai { get; set; }
        public double? TocDoTrucVitDunTrong { get; set; }
        public double? SoLanChat { get; set; }
        public double? TocDoToiCut { get; set; }
        public double? ChieuDaiDatSv { get; set; }
        public double? ChieuDaiBuSv { get; set; }
        public DateTime? ThoiGianHinhAnh { get; set; }
        public string HinhAnh { get; set; }
        public string Size { get; set; }
        public bool? KhongChat { get; set; }
        public int? InnerCode1 { get; set; }
        public int? InnerCode2 { get; set; }
        public int? InnerCode3 { get; set; }
        public int? OuterCode1 { get; set; }
        public int? OuterCode2 { get; set; }
        public int? MaMicroscop { get; set; }
        public bool? RunSys { get; set; }
        public bool? CheckTooling { get; set; }
        public bool? CheckBarcode { get; set; }
        public bool? KqMicrocop { get; set; }
    }
}
