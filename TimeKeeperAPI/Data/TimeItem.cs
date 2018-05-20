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
        public string Id { get; set; }

        [Required]
        public DateTime StartAt { get; set; }

        [Required]
        public DateTime EndAt { get; set; }

        public string Description { get; set; }

        public Work Work { get; set; }
    }
}
