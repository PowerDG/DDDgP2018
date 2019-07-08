using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abptenants
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string TenancyName { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public bool IsActive { get; set; }
        public int? EditionId { get; set; }

        public virtual Abpusers CreatorUser { get; set; }
        public virtual Abpusers DeleterUser { get; set; }
        public virtual Abpeditions Edition { get; set; }
        public virtual Abpusers LastModifierUser { get; set; }
    }
}
