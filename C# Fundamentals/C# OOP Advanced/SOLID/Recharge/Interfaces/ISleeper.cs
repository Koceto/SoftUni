namespace Recharge
{
    public interface ISleeper : IWorker
    {
        void Sleep();

        int WorkingHours { get; }
    }
}