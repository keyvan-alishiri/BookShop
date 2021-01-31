using System;
using BookShop.Areas.Admin.Data;
using BookShop.Areas.Identity.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BookShop.Areas.Identity.IdentityHostingStartup))]
namespace BookShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityDBContextConnection")));

                //services.AddDefaultIdentity<BookShopUser>()
                //    .AddEntityFrameworkStores<IdentityDBContext>();


                services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddDefaultUI()
                 .AddEntityFrameworkStores<IdentityDBContext>()
                 .AddErrorDescriber<ApplicationIdentityErrorDescriber>()
                .AddDefaultTokenProviders();



                services.Configure<IdentityOptions>(Options =>
                {
                    //Configure Password
                    Options.Password.RequireDigit = false;
                    Options.Password.RequiredLength = 7;
                    Options.Password.RequiredUniqueChars = 1;
                    Options.Password.RequireLowercase = false;
                    Options.Password.RequireNonAlphanumeric = false;
                    Options.Password.RequireUppercase = false;

                    Options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                 
                    Options.User.RequireUniqueEmail = true;


                    Options.SignIn.RequireConfirmedEmail = true;


                });




            });
        }
    }
}