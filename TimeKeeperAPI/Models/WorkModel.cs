using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class WorkModelBase
    {
        public Guid ID { get; set; }
        public String WorkName { get; set; }
        public String Color { get; set; }
        public Guid UserID { get; set; }
    }
    public class WorkModel : WorkModelBase
    {
        public UserModel User { get; set; }
        public ICollection<TimeItemModel> TimeItems { get; set; }
    }
}