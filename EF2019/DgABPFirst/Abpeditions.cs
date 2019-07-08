﻿using System;
using System.Collections.Generic;

namespace DgABPFirst
{
    public partial class Abpeditions
    {
        public Abpeditions()
        {
            Abpfeatures = new HashSet<Abpfeatures>();
            Abptenants = new HashSet<Abptenants>();
        }

        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<Abpfeatures> Abpfeatures { get; set; }
        public virtual ICollection<Abptenants> Abptenants { get; set; }
    }
}
