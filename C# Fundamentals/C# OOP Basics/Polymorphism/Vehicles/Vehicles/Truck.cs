namespace Vehicles
{
    public class Truck : Vehicle
    {
        private double airCon = 1.6;

        public Truck(double fuel, double fuelConsumption) : base(fuel, fuelConsumption, double.MaxValue)
        {
        }

        public override void ReFuel(double ammount)
        {
            base.ReFuel(ammount * 0.95);
        }

        public override void Drive(double distance)
        {
            base.Drive(distance, this.airCon);
        }
    }
}