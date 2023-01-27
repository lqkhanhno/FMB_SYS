using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class QcChemicalLabel
    {
        public string ChLabelCode { get; set; }
        public string ItemNo { get; set; }
        public double? Quantity { get; set; }
        public DateTime? PrintDate { get; set; }
        public DateTime? LotNo { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
