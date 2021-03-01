using BookShop.Areas.Api.Middlewares;
using BookShop.Areas.Api.Swagger;
using BookShop.Areas.Identity.Services;
using BookShop.Classes;
using BookShop.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Converters;
using ReflectionIT.Mvc.Paging;
using System;
using System.IO;

namespace BookShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private readonly SiteSettings _siteSettings;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }

       


        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

         

            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));
            services.AddCustomPolicies();
            services.AddCustomIdentityServices(_siteSettings);
            services.AddCustomApplicationServices();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });



            // Don't Show PropertyName In Json Output (PostMan Test)
            //services.Configure<ApiBehaviorOptions>(options =>
            //{
            //    options.InvalidModelStateResponseFactory = ActionContext =>
            //     {
            //         var errors = ActionContext.ModelState
            //         .Where(e => e.Value.Errors.Count() != 0)
            //         .Select(e => e.Value.Errors.First().ErrorMessage).ToList();

            //         return new BadRequestObjectResult(errors);
            //     };

            //});

            services.AddApiVersioning(options =>
            {

                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                // options.ApiVersionReader = new HeaderApiVersionReader("api-version");
                options.ApiVersionReader = ApiVersionReader.Combine(new QueryStringApiVersionReader(),
                    new HeaderApiVersionReader("api-version"));


                //options.Conventions.Controller<SampleV1Controller>().HasApiVersion(new ApiVersion(1, 0));  //If the attribute is removed from the controller, it can be set by default


            });

            services.Configure<FormOptions>(options =>
            {
                options.ValueLengthLimit = int.MaxValue;
                options.MultipartBodyLengthLimit = long.MaxValue;
            });

            services.AddPaging(options =>
            {
                options.ViewName = "Bootstrap4";
                options.HtmlIndicatorDown = "<i class='fa fa-sort-amount-down'></i>";
                options.HtmlIndicatorUp = "<i class='fa fa-sort-amount-up'></i>";
            });






            // Authorizatin
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/SignIn";
                //options.AccessDeniedPath = "/Home/AccessDenied";
            });



            services.AddSwagger();
           









        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseWhen(context => context.Request.Path.StartsWithSegments("/api"), appBuilder =>
            {
                  appBuilder.UseCustomExceptionHandler();


            });

            app.UseWhen(context => !context.Request.Path.StartsWithSegments("/api"), appBuilder =>
            {
                if (env.IsDevelopment())
                {
                    appBuilder.UseDeveloperExceptionPage();
                   
                }
                else
                {
                    appBuilder.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }


            });


            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "node_modules")),
                RequestPath = "/" + "node_modules",
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseCustomIdentityServices();

            app.UseSession();
            app.UseSwaggerAndUI();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
            name: "areas",
            template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute(
                //    name: "default1",
                //    template: "{Area=Admin}/{controller=Books}/{action=Index}/{id?}");  //before add accountController

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");  //change after add accountController

            });
        }
    }
}
