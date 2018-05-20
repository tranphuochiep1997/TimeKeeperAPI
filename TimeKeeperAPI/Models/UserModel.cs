using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class UserModelBase
    {
        public string ID { get; set; }
        public string FullName { get; set; }
    }
    public class UserModel : UserModelBase
    {
        public ICollection<WorkModel> Works { get; set; }
        public ICollection<MemoryModel> Memories { get; set; }
    }
}