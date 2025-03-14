using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//Mvc
            //services.AddRazorPages();//Razor
            //services.AddControllers();//Api
            //services.AddMvc();//All 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles(); //get bootstrp files(css,js)
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                //add new route
                endpoints.MapGet("/index", async context =>
                {
                    await context.Response.WriteAsync("Hello");
                });

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{Controller=Home}/{action=Index}/{id:int?}"); //Id is option

                //defaults: new { action = "Index" },
                //constraints: new { id =new IntRouteConstraint()}  old option

            });
        }
    }
}
