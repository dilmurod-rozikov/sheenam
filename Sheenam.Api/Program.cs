/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Sheenam.Api
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
