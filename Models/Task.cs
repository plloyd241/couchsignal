namespace CouchSignal.Models
{
    public enum TaskTypes
    {
        Action,
        Report
    }

    public class Task
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public TaskTypes Type { get; set; }

        public long DeviceId { get; set; }
        public Device Device { get; set; }
    }
}