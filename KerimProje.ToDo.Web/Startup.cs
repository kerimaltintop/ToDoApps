using KerimProje.ToDo.Web.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Routing.Constraints;
using KerimProje.ToDo.Web.Constraints;

namespace KerimProje.ToDo.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //projeye mvc dahil oldu
            services.AddControllersWithViews();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseCustomStaticFiles();

            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapControllerRoute(
                //    name: "programmingRoute",
                //      pattern: "programming/{lang}",
                //      defaults: new { controllers = "Home", action = "Index" },
                //      constraints: new { lang = new Programming() }
                //    );



                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                    );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
