﻿using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ShoppingKart.Core.Permissions;
using ShoppingKart.Core.Roles;
using ShoppingKart.Core.Users;
using Microsoft.AspNetCore.Builder;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Linq;
using ShoppingKart.Core;
using ShoppingKart.Core.CustomHandler;
using ShoppingKart.EntityFramework;

namespace Nucleus.Web.Core.Extensions
{
    public static class ServiceCollection
    {
        private static SymmetricSecurityKey _signingKey;
        private static JwtTokenConfiguration _jwtTokenConfiguration;

        public static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(configuration["App:CorsOriginPolicyName"],
                    builder =>
                        builder.WithOrigins(configuration["App:CorsOrigins"]
                                .Split(",", StringSplitOptions.RemoveEmptyEntries))
                            .AllowAnyHeader()
                            .AllowAnyMethod());
            });

        }

        //public static void ConfigureAuthentication(this IServiceCollection services)
        //{

        //    services.AddIdentity<User, Role>()
        //      .AddEntityFrameworkStores<NucleusDbContext>()
        //      .AddSignInManager();

        //    services.AddAuthorization(config =>
        //    {
        //        config.AddPolicy("UserPolicy", policyBuilder =>
        //        {
        //            policyBuilder.UserRequireCustomClaim(ClaimTypes.Email);
        //            policyBuilder.UserRequireCustomClaim(ClaimTypes.DateOfBirth);
        //        });
              
        //    });
           


        //}

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            if (!String.IsNullOrEmpty(connectionString))
            {
                services.AddDbContext<NucleusDbContext>(options =>
                   options.UseSqlServer(
                       connectionString
                   )
                   .UseLazyLoadingProxies()
                );
            }
            else
            {
                services.AddDbContext<NucleusDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                   .UseLazyLoadingProxies()
                );
            }
        }

        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IAuthorizationHandler, PoliciesAuthorizationHandler>();
            services.AddScoped<IAuthorizationHandler, RolesAuthorizationHandler>();

            services.AddControllersWithViews();


            //services.AddScoped<IAuthorizationHandler, PermissionHandler>();
            //services.AddScoped<UnitOfWorkActionFilter>();
        }

        public static void ConfigureJwtTokenAuth(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication("CookieAuthentication")
               .AddCookie("CookieAuthentication", config =>
               {
                   config.Cookie.Name = "UserLoginCookie"; // Name of cookie   
                   config.LoginPath = "/Login/UserLogin"; // Path for the redirect to user login page  
                   config.AccessDeniedPath = "/Login/UserAccessDenied";
               });
           
            //services.AddAuthorization(config =>
            //{
            //    config.AddPolicy("UserPolicy", policyBuilder =>
            //    {
            //        policyBuilder.UserRequireCustomClaim(ClaimTypes.Email);
            //        policyBuilder.UserRequireCustomClaim(ClaimTypes.DateOfBirth);

            //    });

            //});
            _signingKey =
            new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(configuration["Authentication:JwtBearer:SecurityKey"]));

            _jwtTokenConfiguration = new JwtTokenConfiguration
            {
                Issuer = configuration["Authentication:JwtBearer:Issuer"],
                Audience = configuration["Authentication:JwtBearer:Audience"],
                SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256),
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(60),
            };

            services.Configure<JwtTokenConfiguration>(config =>
            {
                config.Audience = _jwtTokenConfiguration.Audience;
                config.EndDate = _jwtTokenConfiguration.EndDate;
                config.Issuer = _jwtTokenConfiguration.Issuer;
                config.StartDate = _jwtTokenConfiguration.StartDate;
                config.SigningCredentials = _jwtTokenConfiguration.SigningCredentials;
            });

            //services.AddAuthentication(
            //    options =>
            //    {
            //        //options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    }

            //).AddJwtBearer(jwtBearerOptions =>
            //{
            //    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateActor = true,
            //        ValidateAudience = true,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true,
            //        ValidIssuer = _jwtTokenConfiguration.Issuer,
            //        ValidAudience = _jwtTokenConfiguration.Audience,
            //        IssuerSigningKey = _signingKey
            //    };
            //});

        }

        public static void ConfigureSmtp(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(serviceProvider => new SmtpClient
            {
                Host = configuration["Email:Smtp:Host"],
                Port = int.Parse(configuration["Email:Smtp:Port"]),
                Credentials = new NetworkCredential(configuration["Email:Smtp:Username"], configuration["Email:Smtp:Password"]),
                EnableSsl = bool.Parse(configuration["Email:Smtp:EnableSsl"])
            });
        }
        
    }

}
