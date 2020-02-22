namespace CouchSignal.Core.Models
{
    public class Job
    {
        public long ID { get; set; }
        [Required]
        public string Payload { get; set; }
        [Required]
        public long DeviceID { get; set; }
        public Device Device { get; set; }
    }
}