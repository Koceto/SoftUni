using System;

public class Engine
{
    private Box<string> myBox;

    public Engine()
    {
        this.myBox = new Box<string>();
    }

    public void Run()
    {
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] args = input.Split(' ');

            CommandInterpreter(args);
        }
    }

    private void CommandInterpreter(string[] args)
    {
        string command = args[0];
        string element = String.Empty;

        switch (command)
        {
            case "Add":
                element = args[1];

                this.myBox.Add(element);
                break;

            case "Remove":
                int index = int.Parse(args[1]);

                this.myBox.Remove(index);
                break;

            case "Contains":
                element = args[1];

                Console.WriteLine(this.myBox.Contains(element));
                break;

            case "Swap":
                int firstIndex = int.Parse(args[1]);
                int secondIndex = int.Parse(args[2]);

                this.myBox.Swap(firstIndex, secondIndex);
                break;

            case "Greater":
                element = args[1];

                Console.WriteLine(this.myBox.GreaterThan(element));
                break;

            case "Max":
                Console.WriteLine(this.myBox.Max());
                break;

            case "Min":

                Console.WriteLine(this.myBox.Min());
                break;

            case "Sort":
                this.myBox.Sort();
                break;

            case "Print":
                this.myBox.Print();
                break;
        }
    }
}