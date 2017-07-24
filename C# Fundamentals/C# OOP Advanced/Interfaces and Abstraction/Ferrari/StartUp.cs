using System;

public class Program
{
    public static void Main()
    {
        string driver = Console.ReadLine();

        ICar car = new Ferrari("", driver);

        Console.WriteLine($"{car.Model}/{car.Brake()}/{car.Accelerate()}/{car.Driver}");

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}