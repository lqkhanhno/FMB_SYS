using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string DirectManager { get; set; }
        public string AdAccount { get; set; }
        public string IsUpdate { get; set; }
    }
}
