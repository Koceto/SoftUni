namespace Recharge
{
    public interface IWorker
    {
        string ID { get; }

        void Work(int hours);
    }
}