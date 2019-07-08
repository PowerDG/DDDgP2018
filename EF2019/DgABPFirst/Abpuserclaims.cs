using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpuserclaims
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual Abpusers User { get; set; }
    }
}
