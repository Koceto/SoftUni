using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Google
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                string content = personInfo[1];
                Company company;
                Pokemon pokemon;
                Parent parent;
                Child child;
                Car car;

                Person person = people.FirstOrDefault(p => p.Name == name);

                if (person == null)
                {
                    people.Add(new Person() { Name = name });
                    person = people.Last();
                }

                switch (content)
                {
                    case "company":
                        person.Company = new Company()
                        {
                            Name = personInfo[2],
                            Department = personInfo[3],
                            Salary = double.Parse(personInfo[4], CultureInfo.InvariantCulture)
                        };
                        break;

                    case "pokemon":
                        person.Pokemons.Add(new Pokemon()
                        {
                            Name = personInfo[2],
                            Type = personInfo[3]
                        });
                        break;

                    case "parents":
                        person.Parents.Add(new Parent()
                        {
                            Name = personInfo[2],
                            BirthDay = personInfo[3]
                        });
                        break;

                    case "children":
                        person.Children.Add(new Child()
                        {
                            Name = personInfo[2],
                            BirthDay = personInfo[3]
                        });
                        break;

                    case "car":
                        person.Car = new Car()
                        {
                            Model = personInfo[2],
                            Speed = int.Parse(personInfo[3])
                        };
                        break;
                }
            }

            string lookUp = Console.ReadLine();
            Person info = people.FirstOrDefault(p => p.Name == lookUp);

            Console.WriteLine(info);
        }
    }
}