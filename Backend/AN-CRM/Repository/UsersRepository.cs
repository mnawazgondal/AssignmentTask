using AN_CRM.Controllers.Resources;
using AN_CRM.Model;
using AN_CRM.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AN_CRM.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly crm_databaseContext context;
        private readonly IOptions<ApplicationSettings> appSettings;

        public UsersRepository(crm_databaseContext context, IOptions<ApplicationSettings> appSettings)
        {
            this.context = context;
            this.appSettings = appSettings;
        }
         AddUpdateUserResource IUsersRepository.AddUpdateUser(AddUpdateUserResource resource)
        {

            try
            {
                if (resource.Id == 0)
                {
                    User user = new User();
                    user.FristName = resource.FirstName;
                    user.LastName = resource.LastName;
                    user.Email = resource.Email;
                    user.UserName = resource.UserName;
                    user.Device = resource.Device;
                    user.IpAddress = resource.IpAddress;
                    user.Browser = resource.Browser;
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(resource.Password);
                    user.Password = passwordHash;
                    user.CreatedAt = DateTime.Now;
                    user.IsFristTimeLogin = Convert.ToSByte(0);
                    user.Status = resource.Status == true ? Convert.ToSByte(1) : Convert.ToSByte(0);
                    context.Add(user);
                    context.SaveChanges();

                }
                else
                {
                    var user = context.Users.Where(x => x.Id == resource.Id).FirstOrDefault();
                    user.FristName = resource.FirstName;
                    user.LastName = resource.LastName;
                    user.Email = resource.Email;
                    user.Device = resource.Device;
                    user.IpAddress = resource.IpAddress;
                    user.Browser = resource.Browser;
                    user.UserName = resource.UserName;
                    user.Status = resource.Status == true ? Convert.ToSByte(1) : Convert.ToSByte(0);
                    context.SaveChanges();
                }
                return resource;
            }
            catch (Exception ex)
            {
                return null;
            }
                
               
           
        }

         int IUsersRepository.GetBalance(int userId)
        {
            if (userId != 0)
            {
                var userBalance = context.UsersBalances.Where(u => u.UserId == userId).FirstOrDefault();
                var model = new
                {
                    balance = userBalance.Balance
                };
                return Convert.ToInt32(model.balance);
            }
                return 0;
        }

         GetLoginResult IUsersRepository.Login(LoginResource resource)
        {
            var user = context.Users.Where(x => x.Email == resource.Email).FirstOrDefault();
            if (user != null)
            {
                if (user.Email == resource.Email && BCrypt.Net.BCrypt.Verify(resource.Password, user.Password))
                {

                    {
                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = new ClaimsIdentity(new Claim[]
                            {
                            new Claim("UserId", user.Id.ToString())
                             }),
                            Expires = DateTime.UtcNow.AddMinutes(30),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.Value.Jwt_secret)), SecurityAlgorithms.HmacSha256)
                        };

                        var tokenHandler = new JwtSecurityTokenHandler();
                        var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                        var token = tokenHandler.WriteToken(securityToken);
                        if (user.IsFristTimeLogin == 0)
                        {
                            user.IsFristTimeLogin = Convert.ToSByte(1);
                            UsersBalance balnce = new UsersBalance();
                            balnce.UserId = user.Id;
                            balnce.Balance = 5;
                             context.Add(balnce);
                             context.SaveChanges();

                        }

                        var modl = new GetLoginResult
                        {
                            id=user.Id,
                            Message = "Login Successfully",
                            Token = token,
                            UserName = user.UserName
                        };
                        return modl;
                    }
                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }
        }
    }
}
