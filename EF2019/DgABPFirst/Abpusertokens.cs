using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpusertokens
    {
        public long Id { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireDate { get; set; }

        public virtual Abpusers User { get; set; }
    }
}
