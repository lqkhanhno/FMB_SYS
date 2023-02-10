using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class HrVrVisitorInfor
    {
        public string HrRegId { get; set; }
        public DateTime? RegDate { get; set; }
        public string Department { get; set; }
        public string Registor { get; set; }
        public string Visitor { get; set; }
        public string VisitorCompany { get; set; }
        public string IdNo { get; set; }
        public string LicPlate { get; set; }
        public string CarryOnItem { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public string Training { get; set; }
        public string Protect { get; set; }
        public string RegLunch { get; set; }
        public string RegSpecial { get; set; }
        public string LastUserCommit { get; set; }
        public DateTime? LastTimeCommit { get; set; }
        public string UserCommit { get; set; }
        public string IsActive { get; set; }
        public string NumberVisitor { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
    }
}
