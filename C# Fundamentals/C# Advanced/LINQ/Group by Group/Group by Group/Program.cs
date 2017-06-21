using System;
using System.Collections.Generic;
using System.Linq;

namespace Group_by_Group
{
    public class Group
    {
        public List<string> Students { get; set; }
        public int GroupNumber { get; set; }
    }

    internal class Program
    {
        private static void Main()
        {
            List<Group> groups = new List<Group>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Group currentGroup = new Group();

                currentGroup.GroupNumber = int.Parse(data[2]);
                currentGroup.Students = new List<string>();
                currentGroup.Students.Add($"{data[0]} {data[1]}");

                if (groups.Any(g => g.GroupNumber == currentGroup.GroupNumber))
                {
                    groups.Find(g => g.GroupNumber == currentGroup.GroupNumber).Students.Add(currentGroup.Students.First());
                }
                else
                {
                    groups.Add(currentGroup);
                }
            }

            foreach (var group in groups.OrderBy(s => s.GroupNumber))
            {
                Console.WriteLine($"{group.GroupNumber} - {string.Join(", ", group.Students)}");
            }
        }
    }
}