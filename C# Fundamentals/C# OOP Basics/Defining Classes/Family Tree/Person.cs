using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Family_Tree
{
    internal class Person
    {
        public Person()
        {
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public string Name { get; set; }

        public string BirthDate { get; set; }

        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine($"{this.Name} {this.BirthDate}");
            info.AppendLine("Parents:");

            foreach (var parent in this.Parents)
            {
                info.AppendLine($"{parent.Name} {parent.BirthDate}");
            }

            info.AppendLine("Children:");

            foreach (var child in this.Children)
            {
                info.AppendLine($"{child.Name} {child.BirthDate}");
            }

            return info.ToString();
        }

        public Person Concat(Person first)
        {
            foreach (var firstParent in first.Parents)
            {
                if (this.Parents.All(p => p.Name != firstParent.Name && p.BirthDate != firstParent.BirthDate))
                {
                    this.Parents.Add(firstParent);
                    firstParent.Children.RemoveAll(c => c.Name == this.Name || c.BirthDate == this.BirthDate);
                    firstParent.Children.Add(this);
                }
            }

            foreach (var firstChild in first.Children)
            {
                if (this.Children.All(p => p.Name != firstChild.Name && p.BirthDate != firstChild.BirthDate))
                {
                    this.Children.Add(firstChild);
                    firstChild.Parents.RemoveAll(p => p.Name == this.Name || p.BirthDate == this.BirthDate);
                    firstChild.Parents.Add(this);
                }
            }

            return this;
        }
    }
}