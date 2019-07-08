using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpuserroles
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Abpusers User { get; set; }
    }
}
