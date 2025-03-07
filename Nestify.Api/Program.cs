//===================================
// Welcome Aestdile Startup Company
// Residental Training Software
//===================================


using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace Nestify.Api
{
    public class Program
    {
        public static void Main(string[] args) =>
            CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.UseStartup<Startup>());
        }
    }
}