using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeperAPI.Models;

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

        public string Id { get; set; }

        [StringLength(50)]
        public string WorkName { get; set; }

        [Required]
        public Color Color  { get; set; }

        [Required]
        public User User { get; set; }
        public ICollection<TimeItem> TimeItems { get; set; }
    }
}
