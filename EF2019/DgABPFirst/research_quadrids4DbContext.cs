using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DgABPFirst
{
    public partial class research_quadrids4DbContext : DbContext
    {
        public research_quadrids4DbContext()
        {
        }

        public research_quadrids4DbContext(DbContextOptions<research_quadrids4DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abpauditlogs> Abpauditlogs { get; set; }
        public virtual DbSet<Abpbackgroundjobs> Abpbackgroundjobs { get; set; }
        public virtual DbSet<Abpeditions> Abpeditions { get; set; }
        public virtual DbSet<Abpentitychanges> Abpentitychanges { get; set; }
        public virtual DbSet<Abpentitychangesets> Abpentitychangesets { get; set; }
        public virtual DbSet<Abpentitypropertychanges> Abpentitypropertychanges { get; set; }
        public virtual DbSet<Abpfeatures> Abpfeatures { get; set; }
        public virtual DbSet<Abplanguages> Abplanguages { get; set; }
        public virtual DbSet<Abplanguagetexts> Abplanguagetexts { get; set; }
        public virtual DbSet<Abpnotifications> Abpnotifications { get; set; }
        public virtual DbSet<Abpnotificationsubscriptions> Abpnotificationsubscriptions { get; set; }
        public virtual DbSet<Abporganizationunitroles> Abporganizationunitroles { get; set; }
        public virtual DbSet<Abporganizationunits> Abporganizationunits { get; set; }
        public virtual DbSet<Abppermissions> Abppermissions { get; set; }
        public virtual DbSet<Abppersistedgrants> Abppersistedgrants { get; set; }
        public virtual DbSet<Abproleclaims> Abproleclaims { get; set; }
        public virtual DbSet<Abproles> Abproles { get; set; }
        public virtual DbSet<Abpsettings> Abpsettings { get; set; }
        public virtual DbSet<Abptenantnotifications> Abptenantnotifications { get; set; }
        public virtual DbSet<Abptenants> Abptenants { get; set; }
        public virtual DbSet<Abpuseraccounts> Abpuseraccounts { get; set; }
        public virtual DbSet<Abpuserclaims> Abpuserclaims { get; set; }
        public virtual DbSet<Abpuserloginattempts> Abpuserloginattempts { get; set; }
        public virtual DbSet<Abpuserlogins> Abpuserlogins { get; set; }
        public virtual DbSet<Abpusernotifications> Abpusernotifications { get; set; }
        public virtual DbSet<Abpuserorganizationunits> Abpuserorganizationunits { get; set; }
        public virtual DbSet<Abpuserroles> Abpuserroles { get; set; }
        public virtual DbSet<Abpusers> Abpusers { get; set; }
        public virtual DbSet<Abpusertokens> Abpusertokens { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=192.168.1.102;Database=research_quadrids4Db;Uid=research_home;Pwd=research_home@20190423;SslMode=none;Allow User Variables=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abpauditlogs>(entity =>
            {
                entity.ToTable("abpauditlogs");

                entity.HasIndex(e => new { e.TenantId, e.ExecutionDuration })
                    .HasName("IX_AbpAuditLogs_TenantId_ExecutionDuration");

                entity.HasIndex(e => new { e.TenantId, e.ExecutionTime })
                    .HasName("IX_AbpAuditLogs_TenantId_ExecutionTime");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_AbpAuditLogs_TenantId_UserId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.BrowserInfo).HasColumnType("varchar(512)");

                entity.Property(e => e.ClientIpAddress).HasColumnType("varchar(64)");

                entity.Property(e => e.ClientName).HasColumnType("varchar(128)");

                entity.Property(e => e.CustomData).HasColumnType("varchar(2000)");

                entity.Property(e => e.Exception).HasColumnType("varchar(2000)");

                entity.Property(e => e.ExecutionDuration).HasColumnType("int(11)");

                entity.Property(e => e.ImpersonatorTenantId).HasColumnType("int(11)");

                entity.Property(e => e.ImpersonatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.MethodName).HasColumnType("varchar(256)");

                entity.Property(e => e.Parameters).HasColumnType("varchar(1024)");

                entity.Property(e => e.ReturnValue).HasColumnType("longtext");

                entity.Property(e => e.ServiceName).HasColumnType("varchar(256)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Abpbackgroundjobs>(entity =>
            {
                entity.ToTable("abpbackgroundjobs");

                entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime })
                    .HasName("IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.IsAbandoned).HasColumnType("bit(1)");

                entity.Property(e => e.JobArgs)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.TryCount).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Abpeditions>(entity =>
            {
                entity.ToTable("abpeditions");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DeleterUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<Abpentitychanges>(entity =>
            {
                entity.ToTable("abpentitychanges");

                entity.HasIndex(e => e.EntityChangeSetId)
                    .HasName("IX_AbpEntityChanges_EntityChangeSetId");

                entity.HasIndex(e => new { e.EntityTypeFullName, e.EntityId })
                    .HasName("IX_AbpEntityChanges_EntityTypeFullName_EntityId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityChangeSetId).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityId).HasColumnType("varchar(48)");

                entity.Property(e => e.EntityTypeFullName).HasColumnType("varchar(192)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.EntityChangeSet)
                    .WithMany(p => p.Abpentitychanges)
                    .HasForeignKey(d => d.EntityChangeSetId)
                    .HasConstraintName("FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId");
            });

            modelBuilder.Entity<Abpentitychangesets>(entity =>
            {
                entity.ToTable("abpentitychangesets");

                entity.HasIndex(e => new { e.TenantId, e.CreationTime })
                    .HasName("IX_AbpEntityChangeSets_TenantId_CreationTime");

                entity.HasIndex(e => new { e.TenantId, e.Reason })
                    .HasName("IX_AbpEntityChangeSets_TenantId_Reason");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_AbpEntityChangeSets_TenantId_UserId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.BrowserInfo).HasColumnType("varchar(512)");

                entity.Property(e => e.ClientIpAddress).HasColumnType("varchar(64)");

                entity.Property(e => e.ClientName).HasColumnType("varchar(128)");

                entity.Property(e => e.ExtensionData).HasColumnType("longtext");

                entity.Property(e => e.ImpersonatorTenantId).HasColumnType("int(11)");

                entity.Property(e => e.ImpersonatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Reason).HasColumnType("varchar(256)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Abpentitypropertychanges>(entity =>
            {
                entity.ToTable("abpentitypropertychanges");

                entity.HasIndex(e => e.EntityChangeId)
                    .HasName("IX_AbpEntityPropertyChanges_EntityChangeId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityChangeId).HasColumnType("bigint(20)");

                entity.Property(e => e.NewValue).HasColumnType("varchar(512)");

                entity.Property(e => e.OriginalValue).HasColumnType("varchar(512)");

                entity.Property(e => e.PropertyName).HasColumnType("varchar(96)");

                entity.Property(e => e.PropertyTypeFullName).HasColumnType("varchar(192)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.EntityChange)
                    .WithMany(p => p.Abpentitypropertychanges)
                    .HasForeignKey(d => d.EntityChangeId)
                    .HasConstraintName("FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId");
            });

            modelBuilder.Entity<Abpfeatures>(entity =>
            {
                entity.ToTable("abpfeatures");

                entity.HasIndex(e => new { e.EditionId, e.Name })
                    .HasName("IX_AbpFeatures_EditionId_Name");

                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_AbpFeatures_TenantId_Name");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.EditionId).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(2000)");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.Abpfeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AbpFeatures_AbpEditions_EditionId");
            });

            modelBuilder.Entity<Abplanguages>(entity =>
            {
                entity.ToTable("abplanguages");

                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_AbpLanguages_TenantId_Name");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DeleterUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Icon).HasColumnType("varchar(128)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.IsDisabled).HasColumnType("bit(1)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Abplanguagetexts>(entity =>
            {
                entity.ToTable("abplanguagetexts");

                entity.HasIndex(e => new { e.TenantId, e.Source, e.LanguageName, e.Key })
                    .HasName("IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<Abpnotifications>(entity =>
            {
                entity.ToTable("abpnotifications");

                entity.Property(e => e.Id).HasColumnType("char(36)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Data).HasColumnType("longtext");

                entity.Property(e => e.DataTypeName).HasColumnType("varchar(512)");

                entity.Property(e => e.EntityId).HasColumnType("varchar(96)");

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasColumnType("varchar(512)");

                entity.Property(e => e.EntityTypeName).HasColumnType("varchar(250)");

                entity.Property(e => e.ExcludedUserIds).HasColumnType("longtext");

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasColumnType("varchar(96)");

                entity.Property(e => e.TenantIds).HasColumnType("longtext");

                entity.Property(e => e.UserIds).HasColumnType("longtext");
            });

            modelBuilder.Entity<Abpnotificationsubscriptions>(entity =>
            {
                entity.ToTable("abpnotificationsubscriptions");

                entity.HasIndex(e => new { e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId })
                    .HasName("IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName~");

                entity.HasIndex(e => new { e.TenantId, e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId })
                    .HasName("IX_AbpNotificationSubscriptions_TenantId_NotificationName_Entit~");

                entity.Property(e => e.Id).HasColumnType("char(36)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityId).HasColumnType("varchar(96)");

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasColumnType("varchar(512)");

                entity.Property(e => e.EntityTypeName).HasColumnType("varchar(250)");

                entity.Property(e => e.NotificationName).HasColumnType("varchar(96)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Abporganizationunitroles>(entity =>
            {
                entity.ToTable("abporganizationunitroles");

                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId })
                    .HasName("IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId");

                entity.HasIndex(e => new { e.TenantId, e.RoleId })
                    .HasName("IX_AbpOrganizationUnitRoles_TenantId_RoleId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.OrganizationUnitId).HasColumnType("bigint(20)");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Abporganizationunits>(entity =>
            {
                entity.ToTable("abporganizationunits");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_AbpOrganizationUnits_ParentId");

                entity.HasIndex(e => new { e.TenantId, e.Code })
                    .HasName("IX_AbpOrganizationUnits_TenantId_Code");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(95)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DeleterUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.ParentId).HasColumnType("bigint(20)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId");
            });

            modelBuilder.Entity<Abppermissions>(entity =>
            {
                entity.ToTable("abppermissions");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AbpPermissions_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AbpPermissions_UserId");

                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_AbpPermissions_TenantId_Name");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.IsGranted).HasColumnType("bit(1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Abppermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AbpPermissions_AbpRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Abppermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AbpPermissions_AbpUsers_UserId");
            });

            modelBuilder.Entity<Abppersistedgrants>(entity =>
            {
                entity.ToTable("abppersistedgrants");

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type })
                    .HasName("IX_AbpPersistedGrants_SubjectId_ClientId_Type");

                entity.Property(e => e.Id).HasColumnType("varchar(200)");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.SubjectId).HasColumnType("varchar(200)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Abproleclaims>(entity =>
            {
                entity.ToTable("abproleclaims");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AbpRoleClaims_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.ClaimType })
                    .HasName("IX_AbpRoleClaims_TenantId_ClaimType");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimType).HasColumnType("varchar(256)");

                entity.Property(e => e.ClaimValue).HasColumnType("longtext");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Abproleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AbpRoleClaims_AbpRoles_RoleId");
            });

            modelBuilder.Entity<Abproles>(entity =>
            {
                entity.ToTable("abproles");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_AbpRoles_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_AbpRoles_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_AbpRoles_LastModifierUserId");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedName })
                    .HasName("IX_AbpRoles_TenantId_NormalizedName");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("varchar(128)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DeleterUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Description).HasColumnType("longtext");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.IsDefault).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.IsStatic).HasColumnType("bit(1)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.NormalizedName)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbprolesCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_AbpRoles_AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbprolesDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_AbpRoles_AbpUsers_DeleterUserId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbprolesLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_AbpRoles_AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<Abpsettings>(entity =>
            {
                entity.ToTable("abpsettings");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AbpSettings_UserId");

                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_AbpSettings_TenantId_Name");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Value).HasColumnType("varchar(2000)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Abpsettings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AbpSettings_AbpUsers_UserId");
            });

            modelBuilder.Entity<Abptenantnotifications>(entity =>
            {
                entity.ToTable("abptenantnotifications");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_AbpTenantNotifications_TenantId");

                entity.Property(e => e.Id).HasColumnType("char(36)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Data).HasColumnType("longtext");

                entity.Property(e => e.DataTypeName).HasColumnType("varchar(512)");

                entity.Property(e => e.EntityId).HasColumnType("varchar(96)");

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasColumnType("varchar(512)");

                entity.Property(e => e.EntityTypeName).HasColumnType("varchar(250)");

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasColumnType("varchar(96)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Abptenants>(entity =>
            {
                entity.ToTable("abptenants");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_AbpTenants_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_AbpTenants_DeleterUserId");

                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_AbpTenants_EditionId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_AbpTenants_LastModifierUserId");

                entity.HasIndex(e => e.TenancyName)
                    .HasName("IX_AbpTenants_TenancyName");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ConnectionString).HasColumnType("varchar(1024)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DeleterUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.EditionId).HasColumnType("int(11)");

                entity.Property(e => e.IsActive).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.TenancyName)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbptenantsCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_AbpTenants_AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbptenantsDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_AbpTenants_AbpUsers_DeleterUserId");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.Abptenants)
                    .HasForeignKey(d => d.EditionId)
                    .HasConstraintName("FK_AbpTenants_AbpEditions_EditionId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbptenantsLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_AbpTenants_AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<Abpuseraccounts>(entity =>
            {
                entity.ToTable("abpuseraccounts");

                entity.HasIndex(e => e.EmailAddress)
                    .HasName("IX_AbpUserAccounts_EmailAddress");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_AbpUserAccounts_UserName");

                entity.HasIndex(e => new { e.TenantId, e.EmailAddress })
                    .HasName("IX_AbpUserAccounts_TenantId_EmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_AbpUserAccounts_TenantId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.UserName })
                    .HasName("IX_AbpUserAccounts_TenantId_UserName");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DeleterUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailAddress).HasColumnType("varchar(256)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.Property(e => e.UserLinkId).HasColumnType("bigint(20)");

                entity.Property(e => e.UserName).HasColumnType("varchar(256)");
            });

            modelBuilder.Entity<Abpuserclaims>(entity =>
            {
                entity.ToTable("abpuserclaims");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AbpUserClaims_UserId");

                entity.HasIndex(e => new { e.TenantId, e.ClaimType })
                    .HasName("IX_AbpUserClaims_TenantId_ClaimType");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimType).HasColumnType("varchar(256)");

                entity.Property(e => e.ClaimValue).HasColumnType("longtext");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Abpuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AbpUserClaims_AbpUsers_UserId");
            });

            modelBuilder.Entity<Abpuserloginattempts>(entity =>
            {
                entity.ToTable("abpuserloginattempts");

                entity.HasIndex(e => new { e.UserId, e.TenantId })
                    .HasName("IX_AbpUserLoginAttempts_UserId_TenantId");

                entity.HasIndex(e => new { e.TenancyName, e.UserNameOrEmailAddress, e.Result })
                    .HasName("IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Resu~");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.BrowserInfo).HasColumnType("varchar(512)");

                entity.Property(e => e.ClientIpAddress).HasColumnType("varchar(64)");

                entity.Property(e => e.ClientName).HasColumnType("varchar(128)");

                entity.Property(e => e.TenancyName).HasColumnType("varchar(64)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNameOrEmailAddress).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Abpuserlogins>(entity =>
            {
                entity.ToTable("abpuserlogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AbpUserLogins_UserId");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_AbpUserLogins_TenantId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.LoginProvider, e.ProviderKey })
                    .HasName("IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Abpuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AbpUserLogins_AbpUsers_UserId");
            });

            modelBuilder.Entity<Abpusernotifications>(entity =>
            {
                entity.ToTable("abpusernotifications");

                entity.HasIndex(e => new { e.UserId, e.State, e.CreationTime })
                    .HasName("IX_AbpUserNotifications_UserId_State_CreationTime");

                entity.Property(e => e.Id).HasColumnType("char(36)");

                entity.Property(e => e.State).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.TenantNotificationId)
                    .IsRequired()
                    .HasColumnType("char(36)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Abpuserorganizationunits>(entity =>
            {
                entity.ToTable("abpuserorganizationunits");

                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId })
                    .HasName("IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_AbpUserOrganizationUnits_TenantId_UserId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.OrganizationUnitId).HasColumnType("bigint(20)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Abpuserroles>(entity =>
            {
                entity.ToTable("abpuserroles");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AbpUserRoles_UserId");

                entity.HasIndex(e => new { e.TenantId, e.RoleId })
                    .HasName("IX_AbpUserRoles_TenantId_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_AbpUserRoles_TenantId_UserId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Abpuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AbpUserRoles_AbpUsers_UserId");
            });

            modelBuilder.Entity<Abpusers>(entity =>
            {
                entity.ToTable("abpusers");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_AbpUsers_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_AbpUsers_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_AbpUsers_LastModifierUserId");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedEmailAddress })
                    .HasName("IX_AbpUsers_TenantId_NormalizedEmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedUserName })
                    .HasName("IX_AbpUsers_TenantId_NormalizedUserName");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.AuthenticationSource).HasColumnType("varchar(64)");

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("varchar(128)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.CreatorUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.DeleterUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.EmailConfirmationCode).HasColumnType("varchar(328)");

                entity.Property(e => e.IsActive).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.IsEmailConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.IsLockoutEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.IsPhoneNumberConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.IsTwoFactorEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.LastModifierUserId).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedTime).HasColumnName("modified_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.NormalizedEmailAddress)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.PasswordResetCode).HasColumnType("varchar(328)");

                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(32)");

                entity.Property(e => e.SecurityStamp).HasColumnType("varchar(128)");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_AbpUsers_AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_AbpUsers_AbpUsers_DeleterUserId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_AbpUsers_AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<Abpusertokens>(entity =>
            {
                entity.ToTable("abpusertokens");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AbpUserTokens_UserId");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_AbpUserTokens_TenantId_UserId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.LoginProvider).HasColumnType("varchar(128)");

                entity.Property(e => e.Name).HasColumnType("varchar(128)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20)");

                entity.Property(e => e.Value).HasColumnType("varchar(512)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Abpusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AbpUserTokens_AbpUsers_UserId");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(95)");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });
        }
    }
}
