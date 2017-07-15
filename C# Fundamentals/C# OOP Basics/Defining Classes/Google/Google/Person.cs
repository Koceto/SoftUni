using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Person
    {
        public Person()
        {
            this.Company = new Company();
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Car = new Car();
        }

        public string Name { get; set; }
        public Company Company { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public Car Car { get; set; }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine(this.Name);
            info.AppendLine("Company:");

            if (this.Company.Name != null)
            {
                info.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}");
            }

            info.AppendLine("Car:");

            if (this.Car.Model != null)
            {
                info.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }

            info.AppendLine("Pokemon:");

            foreach (var pokemon in this.Pokemons)
            {
                info.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }

            info.AppendLine("Parents:");

            foreach (var parent in this.Parents)
            {
                info.AppendLine($"{parent.Name} {parent.BirthDay}");
            }

            info.AppendLine("Children:");

            foreach (var child in this.Children)
            {
                info.AppendLine($"{child.Name} {child.BirthDay}");
            }

            return info.ToString();
        }
    }
}