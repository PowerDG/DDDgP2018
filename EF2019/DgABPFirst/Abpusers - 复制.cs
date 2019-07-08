using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public  override partial class Abpusers
    {
        public  override Abpusers()
        {
            Abppermissions = new HashSet<Abppermissions>();
            AbprolesCreatorUser = new HashSet<Abproles>();
            AbprolesDeleterUser = new HashSet<Abproles>();
            AbprolesLastModifierUser = new HashSet<Abproles>();
            Abpsettings = new HashSet<Abpsettings>();
            AbptenantsCreatorUser = new HashSet<Abptenants>();
            AbptenantsDeleterUser = new HashSet<Abptenants>();
            AbptenantsLastModifierUser = new HashSet<Abptenants>();
            Abpuserclaims = new HashSet<Abpuserclaims>();
            Abpuserlogins = new HashSet<Abpuserlogins>();
            Abpuserroles = new HashSet<Abpuserroles>();
            Abpusertokens = new HashSet<Abpusertokens>();
            InverseCreatorUser = new HashSet<Abpusers>();
            InverseDeleterUser = new HashSet<Abpusers>();
            InverseLastModifierUser = new HashSet<Abpusers>();
        }

        public  override long Id { get; set; }
        public  override long? CreatorUserId { get; set; }
        public  override long? ReadLine { get; set; }
        public  override bool IsDeleted { get; set; }
        public  override long? DeleterUserId { get; set; }
        public  override DateTime? DeletionTime { get; set; }
        public  override string AuthenticationSource { get; set; }
        public  override string UserName { get; set; }
        public  override int? TenantId { get; set; }
        public  override string EmailAddress { get; set; }
        public  override string Name { get; set; }
        public  override string Surname { get; set; }
        public  override string Password { get; set; }
        public  override string EmailConfirmationCode { get; set; }
        public  override string PasswordResetCode { get; set; }
        public  override DateTime? LockoutEndDateUtc { get; set; }
        public  override int AccessFailedCount { get; set; }
        public  override bool IsLockoutEnabled { get; set; }
        public  override string PhoneNumber { get; set; }
        public  override bool IsPhoneNumberConfirmed { get; set; }
        public  override string SecurityStamp { get; set; }
        public  override bool IsTwoFactorEnabled { get; set; }
        public  override bool IsEmailConfirmed { get; set; }
        public  override bool IsActive { get; set; }
        public  override string NormalizedUserName { get; set; }
        public  override string NormalizedEmailAddress { get; set; }
        public  override string ConcurrencyStamp { get; set; }
        public  override DateTime CreateTime { get; set; }
        public  override DateTime? ModifiedTime { get; set; }

        public  override virtual Abpusers CreatorUser { get; set; }
        public  override virtual Abpusers DeleterUser { get; set; }
        public  override virtual Abpusers LastModifierUser { get; set; }
        public  override virtual ICollection<Abppermissions> Abppermissions { get; set; }
        public  override virtual ICollection<Abproles> AbprolesCreatorUser { get; set; }
        public  override virtual ICollection<Abproles> AbprolesDeleterUser { get; set; }
        public  override virtual ICollection<Abproles> AbprolesLastModifierUser { get; set; }
        public  override virtual ICollection<Abpsettings> Abpsettings { get; set; }
        public  override virtual ICollection<Abptenants> AbptenantsCreatorUser { get; set; }
        public  override virtual ICollection<Abptenants> AbptenantsDeleterUser { get; set; }
        public  override virtual ICollection<Abptenants> AbptenantsLastModifierUser { get; set; }
        public  override virtual ICollection<Abpuserclaims> Abpuserclaims { get; set; }
        public  override virtual ICollection<Abpuserlogins> Abpuserlogins { get; set; }
        public  override virtual ICollection<Abpuserroles> Abpuserroles { get; set; }
        public  override virtual ICollection<Abpusertokens> Abpusertokens { get; set; }
        public  override virtual ICollection<Abpusers> InverseCreatorUser { get; set; }
        public  override virtual ICollection<Abpusers> InverseDeleterUser { get; set; }
        public  override virtual ICollection<Abpusers> InverseLastModifierUser { get; set; }
    }
}
