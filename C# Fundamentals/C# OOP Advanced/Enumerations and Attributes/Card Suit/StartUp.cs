using System;
using System.Collections;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine($"{input}:");

        Array cards = null;

        if (input.ToLower() == "card suits")
        {
            cards = Enum.GetValues(typeof(CardSuits));
        }
        else if (input.ToLower() == "card ranks")
        {
            cards = Enum.GetValues(typeof(CardRanks));
        }

        Print(cards);
    }

    private static void Print(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
        }
    }
}