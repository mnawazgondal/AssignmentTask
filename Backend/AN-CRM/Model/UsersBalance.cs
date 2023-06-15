using System;
using System.Collections.Generic;

#nullable disable

namespace AN_CRM.Model
{
    public partial class UsersBalance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? Balance { get; set; }

        public virtual User User { get; set; }
    }
}
