using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuel;
        private double litersPerKm;
        private double tankCapacity;

        public Vehicle(double fuel, double fuelConsumption, double tankCapacity)
        {
            this.Fuel = fuel;
            this.LitersPerKm = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double Fuel
        {
            get { return this.fuel; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuel = value;
            }
        }

        public virtual double LitersPerKm
        {
            get { return this.litersPerKm; }
            set { this.litersPerKm = value; }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        public abstract void Drive(double distance);

        public virtual void Drive(double distance, double airCon)
        {
            double consumption = this.LitersPerKm + airCon;
            double fuelRequired = distance * consumption;

            if (this.Fuel < fuelRequired)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.Fuel -= fuelRequired;
        }

        public virtual void ReFuel(double ammount)
        {
            if (ammount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.Fuel + ammount > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.Fuel += ammount;
        }
    }
}