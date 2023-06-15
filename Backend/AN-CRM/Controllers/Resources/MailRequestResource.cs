using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class MailRequestResource
    {
        public string Id { get; set; }
        public string MailTo { get; set; }
        public string Name { get; set; }
        public string  Subject { get; set; }
        public string Body { get; set; }
    }
}
