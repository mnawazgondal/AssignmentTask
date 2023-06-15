using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class AddUpdateUserResource
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public string Device { get; set; }
        [Required]
        public string Browser { get; set; }
        [Required]
        public string IpAddress { get; set; }
    }
}
