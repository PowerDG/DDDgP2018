using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace IdentityServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //https://www.cnblogs.com/Zhang-Xiang/p/10437488.html
        //    .NET Core + Ocelot + IdentityServer4 + Consul 基础架构实现

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
        //{
        //    return WebHost.CreateDefaultBuilder(args).ConfigureServices(services =>
        //    {
        //        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        //        services.AddIdentityServer()
        //            .AddDeveloperSigningCredential()
        //            .AddInMemoryIdentityResources(Config.GetIdentityResources())
        //            .AddInMemoryApiResources(Config.GetApiResources())
        //            .AddInMemoryClients(Config.GetClients())
        //            .AddTestUsers(Config.GetUsers());
        //    }).Configure(app =>
        //    {
        //        app.UseIdentityServer();
        //    });
        //}
    }
}