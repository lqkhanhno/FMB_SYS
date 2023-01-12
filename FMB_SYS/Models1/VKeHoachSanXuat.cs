using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class VKeHoachSanXuat
    {
        public int Id { get; set; }
        public string MaSp { get; set; }
        public double? SpKichThuocChatTieuChuan { get; set; }
        public string Size { get; set; }
        public int? Sl { get; set; }
        public bool KhongChat { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int IdTssp { get; set; }
        public byte TrangThai { get; set; }
        public int? Ca { get; set; }
        public string GhiChu { get; set; }
    }
}
