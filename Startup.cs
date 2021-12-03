using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Service;

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

            // ������������ ������ ��� ��������
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("defualt", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
