using System;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Nucleus.Web.Core.Extensions;
using ShoppingKart.Core;
using ShoppingKart.Core.CustomHandler;
using Swashbuckle.AspNetCore.Filters;

namespace CookieAuthenticationDemo
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            try
            {

               services.AddAuthentication("CookieAuthentication")
               .AddCookie("CookieAuthentication", config =>
                    {
                        config.Cookie.Name = "UserLoginCookie"; // Name of cookie   
                         config.LoginPath = "/Login/UserLogin"; // Path for the redirect to user login page  
                         config.AccessDeniedPath = "/Login/UserAccessDenied";
                    });

                services.AddAuthorization(config =>
                {
                    config.AddPolicy("UserPolicy", policyBuilder =>
                    {
                        policyBuilder.UserRequireCustomClaim(ClaimTypes.Email);
                        policyBuilder.UserRequireCustomClaim(ClaimTypes.DateOfBirth);
                        
                    });
                });

              
                services.AddScoped<IAuthorizationHandler, PoliciesAuthorizationHandler>();
                services.AddScoped<IAuthorizationHandler, RolesAuthorizationHandler>();

                services.AddControllersWithViews();

              
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // who are you?
            app.UseAuthentication();

            // are you allowed?
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=UserLogin}/{id?}");
            });
        }
    }
}