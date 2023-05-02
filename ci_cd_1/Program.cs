using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

namespace ci_cd_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    //config.AddJsonFile($"appsettings.json", false, true);
                    //config.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json");

                    //config.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ENV")}.json");

                    //       appConfig.AddJsonFile($"appsettings.json", false, true);
                    //       appConfig.AddJsonFile($"appsettings{Environment.GetEnvironmentVariable(
                    //"ASPNETCORE_ENVIRONMENT")}.json", false, true);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
