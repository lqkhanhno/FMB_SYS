using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class SanphamTieuchuanlab
    {
        public int Id { get; set; }
        public string KindofNumber { get; set; }
        public double? FmbMhMin { get; set; }
        public double? FmbMhMax { get; set; }
        public double? FmbMs14Min { get; set; }
        public double? FmbMs14Max { get; set; }
        public double? FmbMs14GioiHan { get; set; }
        public double? CmbMsMin { get; set; }
        public double? CmbMsMax { get; set; }
        public double? CmbMsGioiHan { get; set; }
        public double? TsMax { get; set; }
        public double? TsMin { get; set; }
        public double? TimeMin { get; set; }
        public double? TimeMax { get; set; }
        public double? TenlsiUtsMin { get; set; }
        public double? TenlsiBelongMin { get; set; }
        public double? MoistureMax { get; set; }
        public double? GravityCmbMin { get; set; }
        public double? GravityCmbMax { get; set; }
        public double? GravityCmbGioiHan { get; set; }
        public bool? Cmbm { get; set; }
        public bool? Fmbm { get; set; }
        public bool? Fmbr { get; set; }
        public bool? Tuts { get; set; }
        public bool? Tbel { get; set; }
        public bool? Mois { get; set; }
        public bool? Cmbg { get; set; }
    }
}
