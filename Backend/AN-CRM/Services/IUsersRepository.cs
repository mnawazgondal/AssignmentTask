using AN_CRM.Controllers.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Services
{
   public  interface IUsersRepository
    {
         GetLoginResult Login(LoginResource resource);
         AddUpdateUserResource AddUpdateUser(AddUpdateUserResource resource);
         int GetBalance(int userId);
    }
}
