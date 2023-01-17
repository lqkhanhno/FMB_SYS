using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class PMasterListProductSubmit
    {
        public DateTime? RequestTime { get; set; }
        public string RequestUser { get; set; }
        public string IsApproval { get; set; }
        public DateTime? ApprovalTime { get; set; }
        public string ApprovalUser { get; set; }
        public string ProductCode { get; set; }
        public string ProductCustomerCode { get; set; }
        public string ModifiedContent { get; set; }
        public string ModifiedSqlQuery { get; set; }
        public string RecoverSqlQuery { get; set; }
        public int RowId { get; set; }
    }
}
