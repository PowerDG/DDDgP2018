using Abp.AspNetCore;
using Abp.AspNetCore.SignalR.Hubs;
using Abp.Castle.Logging.Log4Net;
using Abp.Extensions;
using Abp.IdentityServer4;
using Castle.Facilities.Logging;
using Fooww.Research.Authentication.JwtBearer;
using Fooww.Research.Authorization.Users;
using Fooww.Research.Configuration;
using Fooww.Research.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace Fooww.Research.Web.Host.Startup
{
    public class Startup
    {
        private const string _defaultCorsPolicyName = "localhost";

        private readonly IConfigurationRoot _appConfiguration;

        public Startup(IHostingEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        private SigningCredentials CreateSigningCredential()
        {
            var credentials = new SigningCredentials(GetSecurityKey(), SecurityAlgorithms.RsaSha256Signature);

            return credentials;
        }

        private RSACryptoServiceProvider GetRSACryptoServiceProvider()
        {
            return new RSACryptoServiceProvider(2048);
        }

        private SecurityKey GetSecurityKey()
        {
            return new RsaSecurityKey(GetRSACryptoServiceProvider());
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddMvc(
                options => options.Filters.Add(new CorsAuthorizationFilterFactory(_defaultCorsPolicyName))
            );

            IdentityRegistrar.Register(services);
            var connectionString = _appConfiguration.GetConnectionString("Default");

            //services.AddIdentityServer()

            // .AddSigningCredential(CreateSigningCredential())
            ////.AddConfigurationStore(options =>
            ////{
            ////    options.ConfigureDbContext = builder =>
            ////  builder.UseMySql(connectionString, sql =>
            ////  sql.MigrationsAssembly("Fooww.Research.EntityFrameworkCore"));
            ////})
            ////.AddOperationalStore(options =>
            ////{
            ////    options.ConfigureDbContext = builder =>
            ////        builder.UseMySql(connectionString,
            ////        sql => sql.MigrationsAssembly(migrationsAssembly));

            ////    // this enables automatic token cleanup. this is optional.
            ////    options.EnableTokenCleanup = true;
            ////    options.TokenCleanupInterval = 30;
            ////})
            ////注释掉了使用内存资源的代码。在ConfigurationDbContext方法内，指定了ConfigurationDbContext将使用MySql数据库
            //.AddInMemoryIdentityResources(IdentityServerConfig.GetIdentityResources())
            //.AddInMemoryApiResources(IdentityServerConfig.GetApiResources())
            //.AddInMemoryClients(IdentityServerConfig.GetClients())
            //.AddAbpPersistedGrants<IAbpPersistedGrantDbContext>()
            //.AddAbpIdentityServer<User>();

            AuthConfigurer.Configure(services, _appConfiguration);
            services.AddSignalR();

            // Configure CORS for angular2 UI
            services.AddCors(
                options => options.AddPolicy(
                    _defaultCorsPolicyName,
                    builder => builder
                        .WithOrigins(
                            // App:CorsOrigins in appsettings.json can contain more than one address separated by comma.
                            _appConfiguration["App:CorsOrigins"]
                                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                .Select(o => o.RemovePostFix("/"))
                                .ToArray()
                        )
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                )
            );

            // Swagger - Enable this line and the related lines in Configure method to enable swagger UI
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "Research API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);

                // Define the BearerAuth scheme that's in use
                options.AddSecurityDefinition("bearerAuth", new ApiKeyScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
            });

            // Configure Abp and Dependency Injection
            return services.AddAbp<ResearchWebHostModule>(
                // Configure Log4Net logging
                options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                )
            );
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(options => { options.UseAbpRequestLocalization = false; }); // Initializes ABP framework.

            app.UseCors(_defaultCorsPolicyName); // Enable CORS!

            app.UseStaticFiles();

            app.UseAuthentication();

            //app.UseJwtTokenMiddleware("IdentityBearer");
            //app.UseIdentityServer();

            app.UseAbpRequestLocalization();

            app.UseSignalR(routes =>
            {
                routes.MapHub<AbpCommonHub>("/signalr");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();
            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(_appConfiguration["App:ServerRootAddress"].EnsureEndsWith('/') + "swagger/v1/swagger.json", "Research API V1");
                options.IndexStream = () => Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("Fooww.Research.Web.Host.wwwroot.swagger.ui.index.html");
            }); // URL: /swagger
        }
    }
}