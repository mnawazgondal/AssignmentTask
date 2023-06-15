using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class GetLoginResult
    {
        public int id { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
    }
}
