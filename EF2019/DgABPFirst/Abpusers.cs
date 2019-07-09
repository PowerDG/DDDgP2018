using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpusers
    {
        public Abpusers()
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
[Column("id")]
public long Id { get; set; }
[Column("creator_user_id")]
public long? CreatorUserId { get; set; }
[Column("last_modifier_user_id")]
public long? LastModifierUserId { get; set; }
[Column("is_deleted")]
public bool IsDeleted { get; set; }
[Column("deleter_user_id")]
public long? DeleterUserId { get; set; }
[Column("deletion_time")]
public DateTime? DeletionTime { get; set; }
[Column("authentication_source")]
public string AuthenticationSource { get; set; }
[Column("user_name")]
public string UserName { get; set; }
[Column("tenant_id")]
public int? TenantId { get; set; }
[Column("email_address")]
public string EmailAddress { get; set; }
[Column("name")]
public string Name { get; set; }
[Column("lockout_end_date_utc")]
public DateTime? LockoutEndDateUtc { get; set; }
[Column("access_failed_count")]
public int AccessFailedCount { get; set; }
[Column("is_lockout_enabled")]
public bool IsLockoutEnabled { get; set; }
[Column("surname")]
public string Surname { get; set; }
[Column("password")]
public string Password { get; set; }
[Column("email_confirmation_code")]
public string EmailConfirmationCode { get; set; }
[Column("password_reset_code")]
public string PasswordResetCode { get; set; }
[Column("normalized_user_name")]
public string NormalizedUserName { get; set; }
[Column("normalized_email_address")]
public string NormalizedEmailAddress { get; set; }
[Column("concurrency_stamp")]
public string ConcurrencyStamp { get; set; }
[Column("create_time")]
public DateTime CreateTime { get; set; }
[Column("modified_time")]
public DateTime? ModifiedTime { get; set; }
[Column("phone_number")]
public string PhoneNumber { get; set; }
[Column("is_phone_number_confirmed")]
public bool IsPhoneNumberConfirmed { get; set; }
[Column("security_stamp")]
public string SecurityStamp { get; set; }
[Column("is_two_factor_enabled")]
public bool IsTwoFactorEnabled { get; set; }
[Column("is_email_confirmed")]
public bool IsEmailConfirmed { get; set; }
[Column("is_active")]
public bool IsActive { get; set; }
        public long Id { get; set; }
        public long? CreatorUserId { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string AuthenticationSource { get; set; }
        public string UserName { get; set; }
        public int? TenantId { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string EmailConfirmationCode { get; set; }
        public string PasswordResetCode { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public int AccessFailedCount { get; set; }
        public bool IsLockoutEnabled { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsActive { get; set; }
        public string NormalizedUserName { get; set; }
        public string NormalizedEmailAddress { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual Abpusers CreatorUser { get; set; }
        public virtual Abpusers DeleterUser { get; set; }
        public virtual Abpusers LastModifierUser { get; set; }
        public virtual ICollection<Abppermissions> Abppermissions { get; set; }
        public virtual ICollection<Abproles> AbprolesCreatorUser { get; set; }
        public virtual ICollection<Abproles> AbprolesDeleterUser { get; set; }
        public virtual ICollection<Abproles> AbprolesLastModifierUser { get; set; }
        public virtual ICollection<Abpsettings> Abpsettings { get; set; }
        public virtual ICollection<Abptenants> AbptenantsCreatorUser { get; set; }
        public virtual ICollection<Abptenants> AbptenantsDeleterUser { get; set; }
        public virtual ICollection<Abptenants> AbptenantsLastModifierUser { get; set; }
        public virtual ICollection<Abpuserclaims> Abpuserclaims { get; set; }
        public virtual ICollection<Abpuserlogins> Abpuserlogins { get; set; }
        public virtual ICollection<Abpuserroles> Abpuserroles { get; set; }
        public virtual ICollection<Abpusertokens> Abpusertokens { get; set; }
        public virtual ICollection<Abpusers> InverseCreatorUser { get; set; }
        public virtual ICollection<Abpusers> InverseDeleterUser { get; set; }
        public virtual ICollection<Abpusers> InverseLastModifierUser { get; set; }
    }
}
