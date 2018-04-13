﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace eshop.api.customer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:8001")
                .UseStartup<Startup>()
                .Build();
    }
}
