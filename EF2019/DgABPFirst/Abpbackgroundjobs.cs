using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpbackgroundjobs
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public string JobType { get; set; }
        public string JobArgs { get; set; }
        public short TryCount { get; set; }
        public DateTime NextTryTime { get; set; }
        public DateTime? LastTryTime { get; set; }
        public bool IsAbandoned { get; set; }
        public byte Priority { get; set; }
    }
}
