using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class VRun
    {
        public int Id { get; set; }
        public string MaSp { get; set; }
        public double? SpKichThuocChatTieuChuan { get; set; }
        public string Size { get; set; }
        public int Idkh { get; set; }
        public int? Sl { get; set; }
        public DateTime? ThoiGian { get; set; }
        public byte TrangThai { get; set; }
    }
}
