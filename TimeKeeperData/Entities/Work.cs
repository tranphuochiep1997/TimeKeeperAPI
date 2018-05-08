using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperData.Entities
{
    public class Work
    {
        public Guid ID { get; set; }
        public String WorkName { get; set; }
        public String Color { get; set; }
        public Guid UserID { get; set; }

        public User User { get; set; }
        public ICollection<TimeItem> TimeItems { get; set; }
    }
}
