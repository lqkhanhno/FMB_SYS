using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models2
{
    public partial class AdmPersonInChargeOfProcess
    {
        public string ProcedureName { get; set; }
        public string StepName { get; set; }
        public int? StepNo { get; set; }
        public string PicUser { get; set; }
    }
}
