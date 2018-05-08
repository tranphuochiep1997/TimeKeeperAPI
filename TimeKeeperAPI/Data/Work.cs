using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperAPI.Data
{
    public enum Color
    {
        color1,
        color2,
        color3,
        color4,
        color5,
    }
    
    public class Work
    {

        public Guid ID { get; set; }

        [StringLength(50)]
        public String WorkName { get; set; }

        [Required]
        public Color Color  { get; set; }

        public Guid UserID { get; set; }

        public User User { get; set; }
        public ICollection<TimeItem> TimeItems { get; set; }
    }
}
