namespace Vehicles
{
    public class Bus : Vehicle
    {
        private double airCon = 1.4;

        public Bus(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            base.Drive(distance, this.airCon);
        }
    }
}