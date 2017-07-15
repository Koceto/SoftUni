using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bag;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        private int Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public IList<Product> Bag
        {
            get { return this.bag.AsReadOnly(); }
        }

        public void Buy(Product product)
        {
            if (product.Price > this.Money)
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
            }

            this.bag.Add(product);
            this.Money -= product.Price;
        }
    }
}