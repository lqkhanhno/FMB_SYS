using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class Thongbao
    {
        public int Id { get; set; }
        public int? IdnhanVien { get; set; }
        public bool? CanhBao { get; set; }
        public bool? TrangThaiLogin { get; set; }
    }
}
