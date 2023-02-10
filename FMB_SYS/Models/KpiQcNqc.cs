using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class KpiQcNqc
    {
        public DateTime? Date { get; set; }
        public double? RubberScrap { get; set; }
        public double? SortingInternal { get; set; }
        public double? SortingExternal { get; set; }
        public double? ExceptionalTransportation { get; set; }
        public double? ReWorkRePack { get; set; }
        public double? BusinessTrip { get; set; }
        public double? WarrantyCost { get; set; }
        public double? AccMtd { get; set; }
        public double? Target { get; set; }
    }
}
