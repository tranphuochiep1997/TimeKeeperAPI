using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class MemoryModelBase
    {
        public string ID { get; set; }
        public string UserID { get; set; }
        public string FileName { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class MemoryModel : MemoryModelBase
    {
        public UserModel User { get; set; }
    }
}