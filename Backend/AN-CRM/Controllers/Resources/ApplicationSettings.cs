using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class ApplicationSettings
    {
        public string Jwt_secret { get; set; }
        public string Client_Url { get; set; }
    }
}
