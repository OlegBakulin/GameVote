using GameVote.Domain.DBServices;
using GameVote.Domain.DBServices.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameVote.Interfaces;
using GameVote.Clients.SliceGame;
using GameVote.Services.InMemory;
using GameVote.Domain.Entities.Interfaces;
using GameVote.Domain.ViewModels;

namespace GameVote
{
    public sealed record Startup(IConfiguration _configuration)
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IDBServices, DBServices>();
            services.AddSingleton<ISliceGameServices, InMemorySliceGameServices>();
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

            //app.UseAuthentication();
            //app.UseAuthorization();

           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Base}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "defaultApi",
                    pattern: "api/{controller}/{id?}");

            });
            
                       /* app.Run(async (context) =>
                        {
                            await context.Response.WriteAsync();
                        });*/
        }
    
    }
}
