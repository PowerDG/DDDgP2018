using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abproles
    {
        public Abproles()
        {
            Abppermissions = new HashSet<Abppermissions>();
            Abproleclaims = new HashSet<Abproleclaims>();
        }

        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDefault { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Description { get; set; }

        public virtual Abpusers CreatorUser { get; set; }
        public virtual Abpusers DeleterUser { get; set; }
        public virtual Abpusers LastModifierUser { get; set; }
        public virtual ICollection<Abppermissions> Abppermissions { get; set; }
        public virtual ICollection<Abproleclaims> Abproleclaims { get; set; }
    }
}
