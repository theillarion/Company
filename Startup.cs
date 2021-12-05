using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Service;
using Company.Domain;
using Company.Domain.Repositories.Abstract;
using Company.Domain.Repositories.EntityFramework;

namespace Company
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration Configuration) =>
            this.Configuration = Configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // ����������� ������� �� appsettings.json
            Configuration.Bind("Project", new Config());

            // ����������� ���������� � �������� ��������
            services.AddTransient<ITextFiledsRepository, EFTextFiledsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();

            // ����������� DataBase
            services.AddDbContext<AppDbContext>((options) => options.UseSqlServer(Config.ConnectionString));

            // ����������� Identity
            services.AddIdentity<IdentityUser, IdentityRole>((options) =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //
            services.ConfigureApplicationCookie((options) =>
            {
                options.Cookie.Name = "CompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            // ���������� ��������� MVC
            services.AddControllersWithViews()
                // ������������� � asp.net core 3.0
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // ��������� �������������
            app.UseRouting();

            // ��������� ��������� ��������� ������ (css, js � �.�.)
            app.UseStaticFiles();

            // ����������� �������������� � ����������� 
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            // ������������ ������ ��� ��������
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("defualt", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
