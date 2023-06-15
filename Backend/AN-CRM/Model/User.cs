using System;
using System.Collections.Generic;

#nullable disable

namespace AN_CRM.Model
{
    public partial class User
    {
        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public sbyte? Status { get; set; }
        public string UserName { get; set; }
        public string Device { get; set; }
        public string IpAddress { get; set; }
        public sbyte IsFristTimeLogin { get; set; }
        public string Browser { get; set; }

        public virtual UsersBalance UsersBalance { get; set; }
    }
}
