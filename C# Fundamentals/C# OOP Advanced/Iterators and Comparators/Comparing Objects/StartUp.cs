using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparing_Objects
{
    public class StartUp
    {
        private static SortedSet<Person> sortedSet = new SortedSet<Person>();
        private static HashSet<Person> hashSet = new HashSet<Person>();

        public static void Main()
        {
            List<Person> people = new List<Person>();

            string input = String.Empty;
            int numberOfPeople = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out numberOfPeople))
                {
                    SortPeople(numberOfPeople);
                    return;
                }

                string[] commandArgs = input.Split(' ');

                string name = commandArgs[0];
                int age = int.Parse(commandArgs[1]);
                string town = commandArgs[2];

                Person currentPerson = new Person(name, age, town);

                people.Add(currentPerson);
            }

            int n = int.Parse(Console.ReadLine());
            Person person = people[n - 1];
            int peopleEqualTotarget = people.Count(p => p.CompareTo(person) == 0);

            if (peopleEqualTotarget == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{peopleEqualTotarget} {people.Count - peopleEqualTotarget} {people.Count}");
            }
        }

        private static void SortPeople(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ');
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age, string.Empty);

                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count + Environment.NewLine + hashSet.Count);
        }
    }
}