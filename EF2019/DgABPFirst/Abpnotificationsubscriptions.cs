using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpnotificationsubscriptions
    {
        public string Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public string NotificationName { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeAssemblyQualifiedName { get; set; }
        public string EntityId { get; set; }
    }
}
