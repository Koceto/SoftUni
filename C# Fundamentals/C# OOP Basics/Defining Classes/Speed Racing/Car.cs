namespace Speed_Racing
{
    public class Car
    {
        public Car(string model, double fuel, double fuelPerKilometer)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelPerKilometer = fuelPerKilometer;
            this.DistanceTraveled = 0;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelPerKilometer { get; set; }

        public double DistanceTraveled { get; set; }

        public bool Move(int distance)
        {
            double fuelRequired = distance * FuelPerKilometer;

            if (Fuel >= fuelRequired)
            {
                this.Fuel -= fuelRequired;
                this.DistanceTraveled += distance;

                return true;
            }
            return false;
        }
    }
}