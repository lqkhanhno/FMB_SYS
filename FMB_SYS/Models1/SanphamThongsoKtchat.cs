using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class SanphamThongsoKtchat
    {
        public int Id { get; set; }
        public int? IdspthongSo { get; set; }
        public double? KichThuocChat { get; set; }
        public double? KichThuocChatMau { get; set; }
        public bool? KhongChat { get; set; }
        public bool? Run { get; set; }
        public double? SpKhoiluongPh { get; set; }
        public double? SpKhoiluongdaiPh { get; set; }
    }
}
