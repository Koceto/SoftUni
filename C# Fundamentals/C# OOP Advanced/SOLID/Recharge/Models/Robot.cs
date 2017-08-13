namespace Recharge
{
    public class Robot : Worker, IRechargeable
    {
        private int capacity;
        private int currentPower;

        public Robot(string id, int capacity) : base(id)
        {
            this.capacity = capacity;
            this.CurrentPower = capacity;
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public int CurrentPower
        {
            get { return this.currentPower; }
            private set { this.currentPower = value; }
        }

        public void Recharge()
        {
            this.currentPower = this.capacity;
        }

        public override void Work(int hours)
        {
            this.CurrentPower -= hours;
        }
    }
}