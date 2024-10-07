namespace EmptyWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllersWithViews(); // Mvc Projesi icin bunun eklenmesi þart
            //builder.Services.AddRazorPages(); // Razor Page Þablonu icin gerekli
            var app = builder.Build();  // builder nesnesini derlendigi yerdir. Burada services icersindeki bagimlilklar cozumlenir.
            //**************** Asagidaki kodlar ise request PipeLine Bolumudur ***************/

            app.UseStaticFiles(); // Burasi wwwroot klasorunu internet uzerinden erililebilir hale getirir

            app.MapControllerRoute(name: "default", 
                pattern: "{controller=Home}/{action=Index}/{id?}");
           // app.MapGet("/", () => @"Hello World");

            app.Run();
        }
    }
}
