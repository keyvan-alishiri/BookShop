using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Identity.Services
{
    public static class AddCustomAuthenticationExtentions
    {
        public static IServiceCollection AddCustomAuthentication(this IServiceCollection services)
        {


            services.AddAuthentication()
               .AddGoogle(Option =>
               {
                   Option.ClientId = "268255985709-9j3gng85mpem1p418ac4239oilhemmi3.apps.googleusercontent.com";
                   Option.ClientSecret = "U6DztW7pNhiTXpwBLhJ4-Uum";

               });


            
              //.AddYahoo(options =>
              //{
              //    options.ClientId = "dj0yJmk9aWxnZVZNTGVwVXhWJnM9Y29uc3VtZXJzZWNyZXQmc3Y9MCZ4PWQz";
              //    options.ClientSecret = "9d68b57943e8035cd0771f49d2b54af10797eb4e";
              //});

            return services;
        }
    }
}
