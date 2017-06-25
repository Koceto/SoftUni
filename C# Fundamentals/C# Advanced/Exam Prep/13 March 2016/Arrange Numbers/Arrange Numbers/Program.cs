using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrange_Numbers
{
    public class Number
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    internal class Program
    {
        private static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<Number> sortedNumbers = new List<Number>();
            List<string> nameBuilder = new List<string>();

            foreach (var number in numbers)
            {
                foreach (char character in number)
                {
                    switch (int.Parse(character.ToString()))
                    {
                        case 0:
                            nameBuilder.Add("zero");
                            break;

                        case 1:
                            nameBuilder.Add("one");
                            break;

                        case 2:
                            nameBuilder.Add("two");
                            break;

                        case 3:
                            nameBuilder.Add("three");
                            break;

                        case 4:
                            nameBuilder.Add("four");
                            break;

                        case 5:
                            nameBuilder.Add("five");
                            break;

                        case 6:
                            nameBuilder.Add("six");
                            break;

                        case 7:
                            nameBuilder.Add("seven");
                            break;

                        case 8:
                            nameBuilder.Add("eight");
                            break;

                        case 9:
                            nameBuilder.Add("nine");
                            break;
                    }
                }

                sortedNumbers.Add(new Number()
                {
                    Name = string.Join("-", nameBuilder),
                    Value = number
                });

                nameBuilder.Clear();
            }

            foreach (Number number in sortedNumbers.OrderBy(n => n.Name))
            {
                nameBuilder.Add(number.Value);
            }

            Console.WriteLine(string.Join(", ", nameBuilder));
        }
    }
}