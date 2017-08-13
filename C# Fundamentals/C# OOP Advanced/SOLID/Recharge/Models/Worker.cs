namespace Recharge
{
    public abstract class Worker
    {
        public Worker(string id)
        {
            this.ID = id;
        }

        public abstract void Work(int hours);

        public string ID { get; private set; }
    }
}