using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class KpiQcSupplierClaim
    {
        public double ClaimId { get; set; }
        public DateTime? DetectDate { get; set; }
        public DateTime? ClaimDate { get; set; }
        public string Supplier { get; set; }
        public string PartName { get; set; }
        public string PartNo { get; set; }
        public DateTime? LotNo { get; set; }
        public string Description { get; set; }
        public double? NgQty { get; set; }
        public double? Ppm { get; set; }
        public double? AdminCost { get; set; }
        public double? NgMaterialCost { get; set; }
        public double? NgFgCost { get; set; }
        public double? NgSortingCost { get; set; }
        public double? NgCompensafeCost { get; set; }
        public double? NgLogisticCost { get; set; }
        public double? NgScrapCost { get; set; }
        public double? NgTotalCost { get; set; }
        public string DebitNoteNo { get; set; }
        public DateTime? DebitNoteDate { get; set; }
        public string SentClaim { get; set; }
        public DateTime? DebitAcceptDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? ReportedDate { get; set; }
    }
}
