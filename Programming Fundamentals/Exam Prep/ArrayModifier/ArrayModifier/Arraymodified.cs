namespace ArrayModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Arraymodified
    {
        public static void Main()
        {
            var myList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command.First().ToLower() == "end")
                {
                    break;
                }
                else if (command.First().ToLower() == "swap")
                {
                    var index = int.Parse(command[1]);
                    var secondIndex = int.Parse(command.Last());
                    var tempValue = myList[index];

                    myList[index] = myList[secondIndex];
                    myList[secondIndex] = tempValue;
                }
                else if (command.First().ToLower() == "multiply")
                {
                    var index = int.Parse(command[1]);
                    var secondIndex = int.Parse(command.Last());

                    myList[index] = myList[index] * myList[secondIndex];
                }
                else if (command.First().ToLower() == "decrease")
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        myList[i]--;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", myList));
        }
    }
}
