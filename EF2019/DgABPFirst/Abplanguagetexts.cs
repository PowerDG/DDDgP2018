using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abplanguagetexts
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public int? TenantId { get; set; }
        public string LanguageName { get; set; }
        public string Source { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
