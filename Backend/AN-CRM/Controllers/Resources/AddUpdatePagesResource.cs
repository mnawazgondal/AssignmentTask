using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class AddUpdatePagesResource
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Url { get; set; }
        public int? ParentPageId { get; set; }
        public string IconClass { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
