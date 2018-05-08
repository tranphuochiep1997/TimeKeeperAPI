using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class UserModelBase
    {
        public Guid ID { get; set; }
        public String FullName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
    public class UserModel : UserModelBase
    {
        public ICollection<WorkModel> Works { get; set; }
        public ICollection<MemoryModel> Memories { get; set; }
    }
}