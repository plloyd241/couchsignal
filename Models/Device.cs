using System;
using System.ComponentModel.DataAnnotations;

namespace CouchSignal.Models
{
    public class Device
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public long RoleID { get; set; }
        public Role Role { get; set; }
    }
}