using System;
using System.Linq;

public class SmartPhone : IBrowse, ICall
{
    public void Browse(string url)
    {
        if (url.Any(x => Char.IsDigit(x)))
        {
            throw new ArgumentException("Invalid URL!");
        }

        Console.WriteLine($"Browsing: {url}!");
    }

    public void Call(string number)
    {
        if (number.Any(x => !Char.IsDigit(x)))
        {
            throw new ArgumentException("Invalid number!");
        }

        Console.WriteLine($"Calling... {number}");
    }
}