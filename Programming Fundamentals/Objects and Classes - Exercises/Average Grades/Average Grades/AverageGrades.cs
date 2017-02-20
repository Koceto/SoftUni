using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new List<ClassGrades>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');

                students.Add(new ClassGrades
                {
                    Name = input[0],
                    Grades = input.Skip(1).Select(double.Parse).Average()
                });
            }

            Console.WriteLine(string.Join
                (Environment.NewLine, students
                .Where(x => x.Grades >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Grades)
                .Select(x => $"{x.Name} -> {x.Grades:f2}")));
        }
    }
}
