using System;

namespace Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Town
        {
            get { return this.town; }
            private set { this.town = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) == 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return this.Name.CompareTo(other.Name);
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;

            return person.Name.Equals(this.Name) && person.Age.Equals(this.Age);
        }

        public override int GetHashCode()
        {
            return new { this.Name, this.Age }.GetHashCode();
        }
    }
}