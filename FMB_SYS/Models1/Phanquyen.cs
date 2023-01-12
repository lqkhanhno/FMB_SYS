using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class Phanquyen
    {
        public int IdPq { get; set; }
        public string ViTriPq { get; set; }
        public bool? Caidatchinh { get; set; }
        public bool? Baotri { get; set; }
        public bool? Lichsuloi { get; set; }
        public bool? Truyxuatdulieuchitiet { get; set; }
        public bool? Truyxuatbaocaonhanh { get; set; }
        public bool? Thaydoichaymoi { get; set; }
        public bool? Kehoachsanxuat { get; set; }
        public bool? Quanly { get; set; }
        public bool? Barcode { get; set; }
        public bool? Microscop { get; set; }
    }
}
