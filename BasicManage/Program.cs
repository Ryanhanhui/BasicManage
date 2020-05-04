using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BasicManage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host=CreateWebHostBuilder(args).Build();
            using (var serviceScope=host.Services.CreateScope())//创建一个新的scope，直接使用和ICacheHelper一样的方式会出现丢失、会报错，生命周期不同
            {
                using (var mdb = serviceScope.ServiceProvider.GetService<MyDBContext>())
                {
                    ICacheHelper cacheHelper = host.Services.GetRequiredService<ICacheHelper>();
                    PublicUtil util = new PublicUtil();
                    util.ReloadCache(mdb, cacheHelper);//初始重新加载缓存
                }
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseUrls("http://*")
                .UseStartup<Startup>();
    }
}
