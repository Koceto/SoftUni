using System;

namespace Recharge
{
    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping..zZzZz");
        }

        public int WorkingHours { get; private set; }

        public override void Work(int hours)
        {
            this.WorkingHours += hours;
        }
    }
}