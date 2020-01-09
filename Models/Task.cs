namespace CouchSignal.Models
{
    public enum TaskTypes
    {
        Action,
        Report
    }

    public class Task
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public TaskTypes Type { get; set; }

        public long DeviceID { get; set; }
        public Device Device { get; set; }
    }
}