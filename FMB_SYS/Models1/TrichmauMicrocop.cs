using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class TrichmauMicrocop
    {
        public int Id { get; set; }
        public int? IdkeHoach { get; set; }
        public int? IdspthongSo { get; set; }
        public string HinhAnh { get; set; }
        public DateTime? ThoiGian { get; set; }
        public double? MrcDoDayLopTrong { get; set; }
        public double? MrcDoDayLopNgoai { get; set; }
        public double? MrcChieuDayTong { get; set; }
        public double? MrcDuongKinhTrong { get; set; }
        public double? MrcDuongKinhNgoai { get; set; }
        public double? MrcDodaimau { get; set; }
        public double? DoDaiMau { get; set; }
        public bool? Run { get; set; }
    }
}
