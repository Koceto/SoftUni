namespace Recharge
{
    public interface IRechargeable : IWorker
    {
        void Recharge();

        int Capacity { get; }

        int CurrentPower { get; }
    }
}