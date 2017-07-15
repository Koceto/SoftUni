using System;
using System.Collections.Generic;

namespace Pizza_Calories
{
    public class Dough
    {
        private string flour;
        private string technique;
        private double weight;

        public Dough(string type, string backing, double weight)
        {
            this.Flour = type;
            this.Technique = backing;
            this.Weight = weight;
        }

        private string Flour
        {
            get { return this.flour; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flour = value;
            }
        }

        private string Technique
        {
            get { return this.technique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.technique = value;
            }
        }

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double Calories()
        {
            double calories = 2 * this.Weight;

            if (this.Flour.ToLower() == "white")
            {
                calories *= 1.5;
            }

            if (this.Technique.ToLower() == "crispy")
            {
                calories *= 0.9;
            }
            else if (this.Technique.ToLower() == "chewy")
            {
                calories *= 1.1;
            }

            return calories;
        }
    }
}