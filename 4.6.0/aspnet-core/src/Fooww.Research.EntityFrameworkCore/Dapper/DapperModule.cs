using System;
using System.Collections.Generic;
using System.Text;


using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Fooww.Research.EntityFrameworkCore.Seed;

 
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Dapper;
using Fooww.Research.EntityFrameworkCore;
using System.Reflection;
//using DapperExtensions;
namespace Fooww.Research.Dapper
{
    [DependsOn(
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpDapperModule)
   )]
    public  class DapperModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ResearchDbContext).GetAssembly());

            //这里会自动去扫描程序集中配置好的映射关系
            //DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(DapperModule).GetAssembly() });


        }
    }
}
