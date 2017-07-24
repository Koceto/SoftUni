using System;

public class StartUp
{
    public static void Main()
    {
        SmartPhone phone = new SmartPhone();
        string[] numbers = Console.ReadLine().Split(' ');
        string[] webPages = Console.ReadLine().Split(' ');

        foreach (var number in numbers)
        {
            try
            {
                phone.Call(number);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        foreach (var webPage in webPages)
        {
            try
            {
                phone.Browse(webPage);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}