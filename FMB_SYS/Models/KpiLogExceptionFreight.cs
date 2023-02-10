using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiLogExceptionFreight
    {
        public DateTime? Date { get; set; }
        public int? NumberExceptionCase { get; set; }
        public int? ExceptionCumul { get; set; }
        public double? ExceptionAmount { get; set; }
        public int? ExceptionAmountCumul { get; set; }
        public double? PreMassProd { get; set; }
        public double? PreClaim { get; set; }
        public double? PreReseachDevelopment { get; set; }
        public double? AbnMassProd { get; set; }
        public double? AbnClaim { get; set; }
        public double? AbnReseachDevelopment { get; set; }
        public double? TransFeeLastMonth { get; set; }
    }
}
