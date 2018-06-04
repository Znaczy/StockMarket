using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebCoreMvcFromScratch.Services;

namespace WebCoreMvcFromScratch
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // whenever app asks for what's on left, give him instance of something on the right
            // AddSingleton - use one instance in whole application
            services.AddSingleton<IGreeter, Greeter>();
            // AddScoped - use one instance per request  and get rid of it
            services.AddScoped<IStockData, InMemoryStocks>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                                IHostingEnvironment env,
                                IConfiguration config,
                                IGreeter greeter,
                                ILogger<Startup> logger,
                                IStockData stockData)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                var greeting = greeter.GetMessageOfTheDay();
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"not found?");
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default",
            "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
