using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class Nhansu
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Sdt { get; set; }
        public int? IdPqns { get; set; }
        public string PassWord { get; set; }
        public bool? TrangThai { get; set; }
    }
}
