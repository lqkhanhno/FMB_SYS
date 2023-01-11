using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class LogEstimateExceptional
    {
        public DateTime Date { get; set; }
        public double? PreMassProd { get; set; }
        public double? PreClaim { get; set; }
        public double? PreRnd { get; set; }
        public double? AbnMassProd { get; set; }
        public double? AbnClaim { get; set; }
        public double? AbnRnd { get; set; }
    }
}
