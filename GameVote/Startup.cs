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
using GameVote.Controllers;
using System.Diagnostics;

namespace GameVote
{
    public sealed record Startup(IConfiguration _configuration)
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors();
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
            app.UseCors(builder => builder.AllowAnyOrigin());
            //app.UseAuthentication();
            //app.UseAuthorization();

            /*
            app.Use(async (context, next) =>
            {
            // получаем конечную точку
            Endpoint endpoint = context.GetEndpoint();

            if (endpoint != null)
            {
                // получаем шаблон маршрута, который ассоциирован с конечной точкой
                var routePattern = (endpoint as Microsoft.AspNetCore.Routing.RouteEndpoint)?.RoutePattern?.RawText;

                    Debug.WriteLine($"Endpoint Name: {endpoint.DisplayName}");
                    Debug.WriteLine($"Route Pattern: {routePattern}");

                    // если конечная точка определена, передаем обработку дальше
                    await next();
                }
                else
                {
                    Debug.WriteLine("Endpoint: null");
                    // если конечная точка не определена, завершаем обработку
                    await context.Response.WriteAsync("Endpoint is not defined");
                }
            });
            */

            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/index", async context =>
                {
                    await context.Response.WriteAsync("Hello Index!");
                });
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
*/

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
