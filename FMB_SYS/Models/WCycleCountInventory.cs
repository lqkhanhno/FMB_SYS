using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class WCycleCountInventory
    {
        public string CcName { get; set; }
        public string LabelCode { get; set; }
        public string WhLocation { get; set; }
        public string PalletNo { get; set; }
        public string Place { get; set; }
        public string Pic { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string ProductCustomerCode { get; set; }
        public double? ProductQuantity { get; set; }
        public DateTime? PlanDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
