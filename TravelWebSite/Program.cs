using Microsoft.Extensions.Configuration; // Eklenen satır
namespace TravelProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)=>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder=>
            {
                webBuilder.UseStartup<StartUp>();

            });
    }
}