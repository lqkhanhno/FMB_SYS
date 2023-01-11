using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class PErrorScanLog
    {
        public string ScannerId { get; set; }
        public string Barcode { get; set; }
        public string ErrorLog { get; set; }
        public DateTime? TimeCreated { get; set; }
    }
}
