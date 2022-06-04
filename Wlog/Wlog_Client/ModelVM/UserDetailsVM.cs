using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Client.ModelVM
{
    public class UserDetailsVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Profision { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Adress { get; set; }
        public string About { get; set; }
        public bool IsVerify { get; set; }
    }
}
