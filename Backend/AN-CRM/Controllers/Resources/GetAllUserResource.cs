using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class GetAllUserResource
    {
        public int Id { get; set; }
        public int userTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string password { get; set; }
        public bool Status { get; set; }

    }
}
