using System;
using System.ComponentModel.DataAnnotations;

namespace CouchSignal.Models
{
    public class Device
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}