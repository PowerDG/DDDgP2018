using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpfeatures
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Discriminator { get; set; }
        public int? EditionId { get; set; }

        public virtual Abpeditions Edition { get; set; }
    }
}
