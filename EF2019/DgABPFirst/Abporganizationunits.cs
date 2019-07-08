using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abporganizationunits
    {
        public Abporganizationunits()
        {
            InverseParent = new HashSet<Abporganizationunits>();
        }

        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int? TenantId { get; set; }
        public long? ParentId { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }

        public virtual Abporganizationunits Parent { get; set; }
        public virtual ICollection<Abporganizationunits> InverseParent { get; set; }
    }
}
