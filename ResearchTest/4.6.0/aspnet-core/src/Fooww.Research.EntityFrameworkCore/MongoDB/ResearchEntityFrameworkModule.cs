using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.MongoDb;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Fooww.Research.EntityFrameworkCore.Seed;
//using Abp.Configuration.Startup;
namespace Fooww.Research.EntityFrameworkCore
{
    [DependsOn(
        typeof(ResearchCoreModule),
        typeof(AbpMongoDbModule)
        //, typeof(AbpZeroCoreEntityFrameworkCoreModule)
        )]
    public class ResearchEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

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
            //IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            IocManager.RegisterAssemblyByConvention(typeof(ResearchEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
