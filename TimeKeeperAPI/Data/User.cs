using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperAPI.Data
{
    public class User
    {
        public Guid ID { get; set; }

        [StringLength(200)]
        public String FullName { get; set; }
        
        [Index("IX_EmailAndPhone", 1, IsUnique =true)]
        [StringLength(12)]
        public String Phone { get; set; }

        [Index("IX_EmailAndPhone", 2, IsUnique = true)]
        [StringLength(255)]
        [EmailAddress]

        public String Email { get; set; }

        [Required]
        [StringLength(50)]
        public String Password { get; set; }

        public ICollection<Work> Works { get; set; }
        public ICollection<Memory> Memories { get; set; }
    }
}
