using System;
using System.Linq;

namespace FirstExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Person newPerson = new Person()
                {
                    name = input[0],
                    age = int.Parse(input[1])
                };

                family.AddMember(newPerson);
            }

            foreach (var person in family.People.Where(p => p.age > 30).OrderBy(p => p.name))
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}