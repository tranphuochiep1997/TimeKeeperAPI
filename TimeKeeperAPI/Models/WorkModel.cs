using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class WorkModelBase
    {
        public string ID { get; set; }
        public string WorkName { get; set; }
        public string Color { get; set; }
        public string UserID { get; set; }
    }
    public class WorkModel : WorkModelBase
    {
        public UserModel User { get; set; }
        public ICollection<TimeItemModel> TimeItems { get; set; }
    }
}