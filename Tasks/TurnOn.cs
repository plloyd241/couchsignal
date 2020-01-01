namespace CouchSignal.Tasks
{
    public class TurnOn : ITask
    {
        private byte[] Command;

        public TurnOn(byte[] command)
        {
            Command = command;
        }
    }
}