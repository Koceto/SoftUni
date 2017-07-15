using System;

namespace Pizza_Calories
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            get { return this.type; }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "sauce" && value.ToLower() != "cheese")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double Calories()
        {
            double calories = 2 * this.Weight;

            if (this.Type.ToLower() == "meat")
            {
                calories *= 1.2;
            }
            else if (this.Type.ToLower() == "veggies")
            {
                calories *= 0.8;
            }
            else if (this.Type.ToLower() == "cheese")
            {
                calories *= 1.1;
            }
            else
            {
                calories *= 0.9;
            }

            return calories;
        }
    }
}