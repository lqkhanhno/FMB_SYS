using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class VChonSp
    {
        public int Id { get; set; }
        public string MaSp { get; set; }
        public double? SpKichThuocChatTieuChuan { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public bool? Run { get; set; }
    }
}
