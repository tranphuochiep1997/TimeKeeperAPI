using System;
using System.Collections.Generic;

namespace TimeKeeperAPI.Data
{
    public class Memory
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public String FileName { get; set; }
        public String Location { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public User User { get; set; }
    }
}