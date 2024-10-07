using GenericReposLib.Abstract;
using GenericReposLib.Concrete;
using Microsoft.EntityFrameworkCore;
using NorthwindEntities.SqlServerEntities;

namespace WebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            string constr = builder.Configuration.GetConnectionString("Northwind");
            

            builder.Services.AddDbContext<SqlNorthwinContext>(options => options.UseSqlServer(constr));
           // builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // Https protokolunu kullanir
            app.UseStaticFiles(); // wwwroot klasorunu internete acar

            app.UseRouting(); // Rooting iþlemleri icin gerekli 
            app.UseAuthentication();// Burasi da kimlik dogrulama icin gerekli middleware
            app.UseAuthorization();// Yetkilendirme iþlemleri icin gerekli middleware'dir

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
