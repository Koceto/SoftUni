using System;
using System.Linq;

public class Engine
{
    public void Run()
    {
        EntityController controller = new EntityController();
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] commandArgs = input.Split(' ');

            string name = commandArgs.First();
            string id = commandArgs.Last();

            if (commandArgs.Length == 2)
            {
                controller.NewRobot(name, id);
            }
            else if (commandArgs.Length == 3)
            {
                int age = int.Parse(commandArgs[1]);

                controller.NewPerson(name, age, id);
            }
        }

        string falseIDs = Console.ReadLine();

        controller.FindFalseIDs(falseIDs);
    }
}