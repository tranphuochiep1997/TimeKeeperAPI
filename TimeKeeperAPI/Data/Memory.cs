using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeKeeperAPI.Models;

namespace TimeKeeperAPI.Data
{
    public class Memory
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Caption { get; set; }

        [Required]
        public User User { get; set; }
    }
}