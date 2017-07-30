using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Students
{
    public static class StartUp
    {
        public static void Main()
        {
            string input;
            List<Student> studentSet = new List<Student>();

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstName = data[0];
                string lastName = data[1];

                studentSet.Add(
                    new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName
                    });
            }

            foreach (var student in studentSet.OrderBy(n => n.LastName).ThenByDescending(n => n.FirstName))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}