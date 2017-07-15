namespace Vehicles
{
    public class Car : Vehicle
    {
        private double airCon = 0.9;

        public Car(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            base.Drive(distance, this.airCon);
        }
    }
}