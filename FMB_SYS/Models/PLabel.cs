using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class PLabel
    {
        public string LabelCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductCustomerCode { get; set; }
        public string ProductRev { get; set; }
        public string ProductName { get; set; }
        public int? ProductQuantity { get; set; }
        public double? ProductWeight { get; set; }
        public string LotNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Line { get; set; }
        public DateTime? ScannedDate { get; set; }
        public string CheckType { get; set; }
        public DateTime? PatrolDate { get; set; }
        public string PatrolOp { get; set; }
        public string PatrolResult { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string ProductType { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public decimal? StandardTime { get; set; }
        public string Shift { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? DateInputWh { get; set; }
        public string OpInputWh { get; set; }
        public DateTime? WhLocateDate { get; set; }
        public string WhLocation { get; set; }
        public string WhOpLocate { get; set; }
        public DateTime? DateInputPackingZone { get; set; }
        public string OpInputPackingZone { get; set; }
        public DateTime? DatePacked { get; set; }
        public string OpPacked { get; set; }
        public string PalletNo { get; set; }
        public DateTime? DateLocatePacked { get; set; }
        public string LocationPacked { get; set; }
        public string OpLocatePacked { get; set; }
        public string Place { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipOp { get; set; }
        public string IsLock { get; set; }
        public string Comment { get; set; }
    }
}
