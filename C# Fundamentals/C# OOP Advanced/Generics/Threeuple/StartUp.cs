using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        FirstInput();
        SecondInput();
        ThirdInput();
    }

    private static void FirstInput()
    {
        Threeuple<string, string, string> myThreeuple = null;

        string[] input = ReadLine();

        string first = string.Join(" ", input.Take(input.Length - 2));
        string second = input[input.Length - 2];
        string third = input.Last();

        myThreeuple = new Threeuple<string, string, string>(first, second, third);

        Console.WriteLine(myThreeuple);
    }

    private static void SecondInput()
    {
        Threeuple<string, int, bool> myThreeuple = null;

        string[] input = ReadLine();

        string first = string.Join(" ", input.Take(input.Length - 2));
        int second = int.Parse(input[input.Length - 2]);
        bool third = input.Last() == "drunk";

        myThreeuple = new Threeuple<string, int, bool>(first, second, third);

        Console.WriteLine(myThreeuple);
    }

    private static void ThirdInput()
    {
        Threeuple<string, double, string> myThreeuple = null;

        string[] input = ReadLine();

        string first = string.Join(" ", input.Take(input.Length - 2));
        double second = Math.Round(double.Parse(input[input.Length - 2]), 1);
        string third = input.Last();

        myThreeuple = new Threeuple<string, double, string>(first, second, third);

        Console.WriteLine(myThreeuple);
    }

    private static string[] ReadLine()
    {
        return Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}