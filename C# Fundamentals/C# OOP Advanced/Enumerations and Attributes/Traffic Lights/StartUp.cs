using System;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        string[] lights = Console.ReadLine().Split(' ');
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= n; i++)
        {
            foreach (var item in lights)
            {
                int index = (int)Enum.Parse(typeof(TrafficLights), item);
                index = (index + i) % 3;
                sb.Append($"{(TrafficLights) index} ");
            }
            sb.AppendLine();
        }

        Console.WriteLine(sb);
    }
}