using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class LichsuLoi
    {
        public int Id { get; set; }
        public int Maloi { get; set; }
        public string NoiDung { get; set; }
        public DateTime? ThoiGianBatdau { get; set; }
        public DateTime? ThoiGianKetthuc { get; set; }
    }
}
