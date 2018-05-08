using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperData.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public String FullName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

        public ICollection<Work> Works { get; set; }
        public ICollection<Memory> Memories { get; set; }
    }
}
