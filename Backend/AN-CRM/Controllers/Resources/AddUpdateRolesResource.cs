using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class AddUpdateRolesResource
    {
        public int Id { get; set; }
        public int UserTypeId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string RoleDescription { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
