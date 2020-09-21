using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CivicsApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CivicsApps
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //IWebHostEnvironment env = null;
            //Environment = env;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<RepresentativeContext>(options =>
            
                //var connectionString = Configuration.GetConnectionString("RepresentativeContext");
                options.UseSqlite(Configuration.GetConnectionString("RepresentativeContext")));

                //if (Environment.IsDevelopment())
                //{
                //    options.UseSqlite(connectionString);
                //}
                //else
                //{
                //    options.UseSqlServer(connectionString);
                //}
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
