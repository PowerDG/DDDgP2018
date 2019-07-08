using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpusernotifications
    {
        public string Id { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public string TenantNotificationId { get; set; }
        public int State { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
