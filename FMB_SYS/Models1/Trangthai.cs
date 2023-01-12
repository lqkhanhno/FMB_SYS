using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class Trangthai
    {
        public int Id { get; set; }
        public string May { get; set; }
        public string ViTri { get; set; }
        public byte? TrangThai1 { get; set; }
        public string NoiDung { get; set; }
        public DateTime? ThoiGian { get; set; }
    }
}
