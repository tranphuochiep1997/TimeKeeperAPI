using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class MemoryModelBase
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public String FileName { get; set; }
        public String Location { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
    public class MemoryModel : MemoryModelBase
    {
        public UserModel User { get; set; }
    }
}