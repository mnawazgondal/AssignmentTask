using AN_CRM.Controllers.Resources;
using AN_CRM.Model;
using AN_CRM.Repository;
using AN_CRM.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AN_CRM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.WithOrigins(Configuration["ApplicationSettings:Client_Url"].ToString()));
            });
            services.AddControllers();
            string mySqlConnectionStr = Configuration.GetConnectionString("DevConnection");
            services.AddDbContextPool<crm_databaseContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));
            services.AddScoped<IUsersRepository, UsersRepository>();
            //Inject Appsettings
            services.Configure<ApplicationSettings>(Configuration.GetSection("ApplicationSettings"));

            //Secureity token configuration
            var key = Encoding.UTF8.GetBytes(Configuration["ApplicationSettings:Jwt_secret"].ToString());
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                //x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero,
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(options => options
            //.WithOrigins(Configuration+["ApplicationSettings:Client_Url"].ToString())
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            app.UseHttpsRedirection();
          
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
