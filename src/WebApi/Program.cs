using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppHealthHostingConfiguration(options =>
                {
                    options.HealthEndpoint = "/_system/health";
                    options.PingEndpoint = "/_system/ping";
                })
                .UseStartup<Startup>();
    }
}
