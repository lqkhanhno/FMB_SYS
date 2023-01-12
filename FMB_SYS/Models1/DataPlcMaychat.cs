using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class DataPlcMaychat
    {
        public int Id { get; set; }
        public bool? ChatMau { get; set; }
        public bool? ChatMauSl { get; set; }
        public int? SlchatMau { get; set; }
        public bool? Auto { get; set; }
        public bool? Man { get; set; }
        public double? DoTre { get; set; }
        public bool? Coi { get; set; }
        public double? KichThuocChat { get; set; }
        public double? ChieuDaiDatSv { get; set; }
        public double? ChieuDaiBuSv { get; set; }
        public double? KichThuocChatMau { get; set; }
        public double? DuongkinhZumbachThucte { get; set; }
        public int? SoLanChat { get; set; }
        public double? TocDoToi { get; set; }
        public bool? ChangedMaSp { get; set; }
        public byte? OnCut { get; set; }
        public byte? Toi { get; set; }
        public byte? BangTai { get; set; }
        public byte? Bom { get; set; }
        public byte? MayChat { get; set; }
        public bool? KhongChat { get; set; }
        public double? SpKhoiluongPh { get; set; }
        public double? SpKhoiluongdaiPh { get; set; }
        public double? MinZb { get; set; }
        public double? MaxZb { get; set; }
        public bool? RunSys { get; set; }
        public bool? WriteData { get; set; }
        public bool? Write { get; set; }
    }
}
