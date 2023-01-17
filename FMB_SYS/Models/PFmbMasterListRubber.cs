using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class PFmbMasterListRubber
    {
        public string RubberName { get; set; }
        public string RubberType { get; set; }
        public double? VadilityMin { get; set; }
        public double? VadilityMax { get; set; }
    }
}
