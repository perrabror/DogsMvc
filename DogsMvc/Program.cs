using DogsMvc.Models;
namespace DogsMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();  // Include this line
                endpoints.MapDefaultControllerRoute();  // Include this line if you want to use default routing
            });

            app.UseStaticFiles();

            app.Run();
        }
    }
}