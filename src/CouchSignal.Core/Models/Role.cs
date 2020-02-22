namespace CouchSignal.Core.Models
{
    public class Role
    {
        public const string ADMIN = "Admin";
        public const string FOREMAN = "Foreman";
        public const string WORKER = "Worker";

        public long ID { get; set; }
        public string Name { get; set; }
    }
}