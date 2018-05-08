using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperData.Entities
{
    public class TimeItem
    {
        public Guid ID { get; set; }
        public DateTimeOffset StartAt { get; set; }
        public DateTimeOffset EndAt { get; set; }
        public String Description { get; set; }
        public Guid WorkID { get; set; }

        public Work Work { get; set; }
    }
}
