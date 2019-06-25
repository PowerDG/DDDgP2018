using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace consulDg
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }


        //https://www.cnblogs.com/zhengyazhao/p/10749620.html
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)

    {
            var config = new ConfigurationBuilder().AddCommandLine(args)
              .Build();//获取配置信息
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls($"http://{ config["ip"]}:{config["port"]}")//配置ip地址和端口地址
                .UseStartup<Startup>();
        }


    }
}
