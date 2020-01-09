using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouchSignal.Models
{
    public class Device
    {
        public long ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public long RoleID { get; set; }
        public Role Role { get; set; }

        public List<Task> Tasks { get; set; }
    }
}