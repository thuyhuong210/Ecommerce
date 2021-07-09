using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using ASP.NET_CORE_Final_2019.Areas.Repository;
using ASP.NET_CORE_Final_2019.Areas.Services;
using ASP.NET_CORE_Final_2019.Models;
using ASP.NET_CORE_Final_2019.Repository;
using ASP.NET_CORE_Final_2019.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NET_CORE_Final_2019
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddDbContext<VEGEFOOD_DBContext>(option =>
            //    option.UseSqlServer("Server=.\\SQLEXPRESS;Database=VEGEFOOD_DB;Trusted_Connection=True;"));
            // test
            services.AddDbContext<VEGEFOOD_DBContext>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("VEGEFOOD_DBContext")));
            //
            services.AddScoped<DbContext, VEGEFOOD_DBContext>();
            //
            services.AddSingleton(provider => Configuration);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddTransient<IFSanpham, SanphamRepository>();
            services.AddTransient<IFDonHang, DonhangRepository>();
            services.AddTransient<INhaCungCap, NhaCungCapRepository>();
            services.AddTransient<IKhachHang, KhachHangRepository>();
            services.AddTransient<IDonHang, DonHangRepository>();
            services.AddTransient<ILoaiSanPham, LoaiSanPhamRepository>();
            services.AddTransient<IThongKe, ThongKeRepository>();
            services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
            services.AddSession(cfg => {                    // Đăng ký dịch vụ Session             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(0, 180, 0);    // Thời gian tồn tại của Session
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute("areaRoute", "{area:exists}/{controller=Admin}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Cha}/{action=Start}/{id?}");
            });

        }
    }
}
