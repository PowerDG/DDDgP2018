using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpuserlogins
    {
        public long Id { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }

        public virtual Abpusers User { get; set; }
    }
}
