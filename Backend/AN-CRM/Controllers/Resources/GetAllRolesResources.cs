using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class GetAllRolesResources
    {
        public int Id { get; set; }
        public string RoleName  { get; set; }
        public string RoleDescription { get; set; }
        public int UserTypeId { get; set; }
        public string RoleTypeName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
