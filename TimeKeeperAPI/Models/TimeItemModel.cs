using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeKeeperAPI.Models
{
    public class TimeItemModelBase
    {
        public string ID { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string Description { get; set; }
        public string WorkID { get; set; }
    }
    public class TimeItemModel : TimeItemModelBase
    {
        public WorkModel Work { get; set; }
    }
}