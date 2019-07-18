using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Abp.Modules;
using Abp.MongoDb;
using Abp.Configuration.Startup;


namespace Fooww.Research.MongoDB
{
    [DependsOn(typeof(AbpMongoDbModule), typeof(ResearchCoreModule))]
    public  class ResearchDbContext : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
            //MongoDB数据库地址
            Configuration.Modules.AbpMongoDb().ConnectionString = "mongodb://localhost";
            //MongoDB数据库名称
            Configuration.Modules.AbpMongoDb().DatatabaseName = "MyProject";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
