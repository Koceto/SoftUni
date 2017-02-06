using System;
using System.Linq;

public class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();
        
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int[] args = new int[2];
            string command = input[0].ToString();

            if (command == "stop")
            {
                return;
            }

            if (command.Equals("add") || command.Equals("subtract") || command.Equals("multiply"))
            {
                args[0] = int.Parse(input[1]);
                args[1] = int.Parse(input[2]);

                PerformAction(array, command, args);
            }
            else
            {
                PerformAction(array, command, args);
            }
            PrintArray(array);

        }
    }

    public static void PerformAction(long[] array, string action, int[] args)
    {
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
    }

    public static void ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
    }

    public static void ArrayShiftLeft(long[] array)
    {
        long temp = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;

    }

    public static void PrintArray(long[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
