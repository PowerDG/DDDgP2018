using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpentitychanges
    {
        public Abpentitychanges()
        {
            Abpentitypropertychanges = new HashSet<Abpentitypropertychanges>();
        }

        public long Id { get; set; }
        public DateTime ChangeTime { get; set; }
        public byte ChangeType { get; set; }
        public long EntityChangeSetId { get; set; }
        public string EntityId { get; set; }
        public string EntityTypeFullName { get; set; }
        public int? TenantId { get; set; }

        public virtual Abpentitychangesets EntityChangeSet { get; set; }
        public virtual ICollection<Abpentitypropertychanges> Abpentitypropertychanges { get; set; }
    }
}
