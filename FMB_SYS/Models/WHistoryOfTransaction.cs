﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class WHistoryOfTransaction
    {
        public string LabelCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductCustomerCode { get; set; }
        public int? ProductQuantity { get; set; }
        public string LotNo { get; set; }
        public string Transaction { get; set; }
        public string Location { get; set; }
        public string PalletNo { get; set; }
        public DateTime? InputTime { get; set; }
        public string Pic { get; set; }
        public string InvoiceNo { get; set; }
        public string TruckNo { get; set; }
        public string Comment { get; set; }
    }
}
