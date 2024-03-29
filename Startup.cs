using GoutDSSAspNetCore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")) // read out from appsetting.json and search the ConnectionStrings section for DefaultConnection             //passing cnn str here in usesqlserver
            );
            // This service allows using Mvc framework functionality
            services.AddControllersWithViews();

            // Register MockPatientRepository as a service through dependency injection. Each request has a new instance of this MockPatientRepository
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDiagnosisDetail, DiagnosisDetailRepository>();
            services.AddScoped<IDiagnosisResult, DiagnosisResultRepository>();

            // Add 2 services below to use Identity functionalities

            //This services add Identity service and specifies to use AppDbContext as its EF class for storing data
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();
            // Add Razor page for Identity pages 
            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseRouting(); // use convention based routing mechanism
            app.UseAuthentication(); // allow using AspNetCore.Identity - the authentication feature
            app.UseEndpoints(endpoints => // get collection of endpoints
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}" // :int? to check if id is int (contraints add after : ), if it not an int -> no match
                        // Home and Index are default value if no part of URL coresponding to them 
                    );
            }); 
        }
    }
}
