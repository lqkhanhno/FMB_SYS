using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class PFmbLabel
    {
        public string CartId { get; set; }
        public string RubberName { get; set; }
        public double? RubberWeight { get; set; }
        public DateTime? MixingDate { get; set; }
        public DateTime? InputTime { get; set; }
        public string PicInput { get; set; }
        public int? FmbLine { get; set; }
        public int? FmbNo { get; set; }
        public string Place { get; set; }
        public string LabKind { get; set; }
        public DateTime? MinDuedate { get; set; }
        public DateTime? MaxDuedate { get; set; }
        public string PicOutput { get; set; }
        public string PicReturn { get; set; }
        public string PicRemove { get; set; }
    }
}
