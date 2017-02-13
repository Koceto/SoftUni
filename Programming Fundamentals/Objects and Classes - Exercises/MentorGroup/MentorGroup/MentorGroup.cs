using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Students
{
    public List<string> Comments { get; set; }

    public List<DateTime> Dates { get; set; }
}

namespace MentorGroup
{
    public class MentorGroup
    {
        public static void Main()
        {
            var students = new SortedDictionary<string, Students>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0].ToLower() == "end")
                {
                    break;
                }

                var currStudent = input[0];
                var currDate = input
                    .Skip(1)
                    .ToList();

                if (!students.ContainsKey(currStudent))
                {
                    students[currStudent] = new Students
                    {
                        Dates = new List<DateTime>(),
                        Comments = new List<string>()
                    };
                }

                foreach (var date in currDate)
                {
                    students[currStudent].Dates.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
            }

            while (true)
            {
                var input = Console.ReadLine()
                    .Trim()
                    .Split('-');

                if (input[0].ToLower() == "end of comments")
                {
                    break;
                }

                var currStudent = input[0];
                var currComment = input[1];

                if (students.ContainsKey(currStudent))
                {
                    students[currStudent].Comments.Add(currComment);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");

                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Value.Dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
