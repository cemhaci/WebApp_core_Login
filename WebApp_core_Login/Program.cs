using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection;
using WebApp_core_Login.Models;

namespace WebApp_core_Login
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());  //assambly bizim solication projemiz. ve assambly de profile classýmýzý bul ve onu execute et

            builder.Services.AddDbContext<DatabaseContext>(o=>o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o =>
            {
                o.Cookie.Name="AuthCookie";
                o.ExpireTimeSpan=TimeSpan.FromDays(1);
                o.SlidingExpiration=false;  //1 gün dolduðunda silinecek. süre ötelensin mi= false
                o.LoginPath="/Account/Login";
                o.LogoutPath="/Account/Logout";
                o.AccessDeniedPath="/Home/AccesDenied";
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); // cookie nin çalýþmasýný tetikliyor bu yoksa cookie çalýþmýyor
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}