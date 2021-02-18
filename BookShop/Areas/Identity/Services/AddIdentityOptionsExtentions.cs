using BookShop.Areas.Identity.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Identity.Services
{
    public static class AddIdentityOptionsExtentions
    {
        public static IServiceCollection AddIdentityOptions(this IServiceCollection services)
        {

           ////////////////////////////identityHostingStartup//////////////////////////////////
            services.AddIdentity<ApplicationUser, ApplicationRole>()

                .AddEntityFrameworkStores<BookShopContext>()
                .AddErrorDescriber<ApplicationIdentityErrorDescriber>()
               .AddDefaultTokenProviders();



            services.Configure<IdentityOptions>(Options =>
            {
                //Configure Password
                Options.Password.RequireDigit = false;
                Options.Password.RequiredLength = 6;
                Options.Password.RequiredUniqueChars = 1;
                Options.Password.RequireLowercase = false;
                Options.Password.RequireNonAlphanumeric = false;
                Options.Password.RequireUppercase = false;

                Options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

                Options.User.RequireUniqueEmail = true;


                //Configure RequireConfirmedEmail
                Options.SignIn.RequireConfirmedEmail = true;



                //LockUserAccount
                Options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                Options.Lockout.MaxFailedAccessAttempts = 3;

            });


            return services;
        }
    }
}
