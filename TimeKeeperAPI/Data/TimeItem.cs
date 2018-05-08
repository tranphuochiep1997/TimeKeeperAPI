using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperAPI.Data
{
    public class TimeItem
    {
        public Guid ID { get; set; }

        [Required]
        public DateTimeOffset StartAt { get; set; }

        [Required]
        public DateTimeOffset EndAt { get; set; }

        public String Description { get; set; }
        public Guid WorkID { get; set; }

        public Work Work { get; set; }
    }
}
