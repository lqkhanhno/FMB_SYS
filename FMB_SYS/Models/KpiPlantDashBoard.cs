using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class KpiPlantDashBoard
    {
        public string ItemName { get; set; }
        public double? Value { get; set; }
        public string ValueString { get; set; }
        public string Color { get; set; }
        public DateTime? Date { get; set; }
    }
}
