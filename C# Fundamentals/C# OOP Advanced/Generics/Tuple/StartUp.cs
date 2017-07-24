using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        Tuple<string, string> myTuple = null;

        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            myTuple = new Tuple<string, string>(string.Join(" ", input.Take(input.Length - 1)), input.Last());

            Console.WriteLine(myTuple);
        }
    }
}