using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class KpiHrAbsenteeism
    {
        public int AbsentId { get; set; }
        public DateTime? Date { get; set; }
        public string AbsentType { get; set; }
        public double? EmployeeNo { get; set; }
        public string Comment { get; set; }
    }
}
