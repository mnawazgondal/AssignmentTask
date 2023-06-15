using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class AddUpdateUserTypeResource
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        [Required]
        public sbyte? IsActive { get; set; }
    }
}
