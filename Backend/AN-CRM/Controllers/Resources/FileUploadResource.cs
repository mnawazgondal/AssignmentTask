using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class FileUploadResource
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [MaxLength(255)]
        public string Message { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public string Key { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public int UserId { get; set; }
    }   
}
