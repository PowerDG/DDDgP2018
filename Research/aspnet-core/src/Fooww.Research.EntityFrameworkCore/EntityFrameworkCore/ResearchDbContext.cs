using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Fooww.Research.Authorization.Roles;
using Fooww.Research.Authorization.Users;
using Fooww.Research.MultiTenancy;
using Abp.IdentityServer4;

namespace Fooww.Research.EntityFrameworkCore
{
    public class ResearchDbContext : AbpZeroDbContext<Tenant, Role, User, ResearchDbContext>
    //, IAbpPersistedGrantDbContext
    {
        /* Define a DbSet for each entity of the application */

        //public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder); modelBuilder.ConfigurePersistedGrantEntity();
        //}

        public ResearchDbContext(DbContextOptions<ResearchDbContext> options)
            : base(options)
        {
        }
    }
}