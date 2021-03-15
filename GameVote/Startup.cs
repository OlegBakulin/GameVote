using GameVote.Domain.DBServices;
using GameVote.Domain.DBServices.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GameVote.Interfaces;
using GameVote.Services.InMemory;
using GameVote.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using WebStoreCoreApplicatioc.DAL;
using System;
using Microsoft.AspNetCore.Http;

namespace GameVote
{
    public sealed record Startup(IConfiguration _configuration)
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IDBServices, DBServices>();
            services.AddSingleton<ISliceGameServices, InMemorySliceGameServices>();

            //////////
            services.AddIdentity<User, IdentityRole>()
                .AddUserStore<WebStoreContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options => 
            {
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            //////////
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Index");
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseRouting();

            //////////
            
            app.UseAuthentication();
            app.UseAuthorization();


            //////////

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Base}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "defaultApi",
                    pattern: "api/{controller}/{id?}");
            });
        }
    }
}
