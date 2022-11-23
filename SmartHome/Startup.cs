using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies; //login icin cerezler dahil edildi, authorize iþlemi

namespace SmartHome
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddControllersWithViews();

            services.AddMvc().AddRazorRuntimeCompilation();
            //login yönlendirme cookei,authorize oncesi
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(x =>
            {
                x.LoginPath = "/AdminGiris/GirisYap/";
            });
            services.AddMvc();

            //Cookie ayarlarý
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Login";
                options.LoginPath = "/Logout";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication(); //LOGÝN ÝÇÝN 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                       name: "default",
                       pattern: "{controller}/{action}/{id?}");

                endpoints.MapControllerRoute(
                       name: "home",
                       pattern: "/",
                       defaults: new { controller = "Home", action = "Index" });

                //login  route icin
                endpoints.MapControllerRoute(
                       name: "admin-giris",
                       pattern: "/admin-giris",
                       defaults: new { controller = "AdminGiris", action = "GirisYap" });

                endpoints.MapControllerRoute(
                      name: "a_smarthome-sayfasi",
                      pattern: "/a_smarthome-sayfa",
                      defaults: new { controller = "A_smarthome", action = "Index" });

                endpoints.MapControllerRoute(
                     name: "security-sayfasi",
                     pattern: "/security-sayfa",
                     defaults: new { controller = "Security", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "admin-logout",
                   pattern: "/admin-logout",
                   defaults: new { controller = "AdminGiris", action = "LogOut" });


                endpoints.MapControllerRoute(
                      name: "services-sayfasi",
                      pattern: "/services-sayfasi",
                      defaults: new { controller = "Services", action = "Index" });

                endpoints.MapControllerRoute(
                      name: "singleproduct-sayfasi",
                      pattern: "/singleproduct-sayfasi",
                      defaults: new { controller = "SingleProduct", action = "SingleProductIndex" });

                endpoints.MapControllerRoute(
                     name: "supportcenter-sayfasi",
                     pattern: "/supportcenter-sayfasi",
                     defaults: new { controller = "SupportCenter", action = "SupportCenterIndex" });

                endpoints.MapControllerRoute(
                   name: "partners-sayfasi",
                   pattern: "/partners-sayfasi",
                   defaults: new { controller = "Partners", action = "PartnersIndex" });

                endpoints.MapControllerRoute(
                    name: "aboutus-sayfasi",
                    pattern: "/aboutus-sayfasi",
                    defaults: new { controller = "AboutUs", action = "AboutUsIndex" });

                endpoints.MapControllerRoute(
                  name: "concat-sayfasi",
                  pattern: "/concat-sayfasi",
                  defaults: new { controller = "Concat", action = "ConcatIndex" });


                endpoints.MapControllerRoute(
                 name: "blog-sayfasi",
                 pattern: "/blog-sayfasi",
                 defaults: new { controller = "Blog", action = "Index" });

            });


        }
    }
}
