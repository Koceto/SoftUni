using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private int numberOfToppings;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, int toppings)
        {
            this.Name = name;
            this.NumberOfToppings = toppings;
            this.toppings = new List<Topping>(numberOfToppings);
        }

        private int NumberOfToppings
        {
            get { return this.numberOfToppings; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.numberOfToppings = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        private string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        private double Calories()
        {
            return this.Dough.Calories() + this.toppings.Sum(t => t.Calories());
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Calories():f2} Calories";
        }
    }
}