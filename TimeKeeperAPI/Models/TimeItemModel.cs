using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class TimeItemModelBase
    {
        public Guid ID { get; set; }
        public DateTimeOffset StartAt { get; set; }
        public DateTimeOffset EndAt { get; set; }
        public String Description { get; set; }
        public Guid WorkID { get; set; }
    }
    public class TimeItemModel : TimeItemModelBase
    {
        public WorkModel Work { get; set; }
    }
}