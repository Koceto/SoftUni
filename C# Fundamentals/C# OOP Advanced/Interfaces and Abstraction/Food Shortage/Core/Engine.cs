using System;

public class Engine
{
    private EntityController controller;

    public Engine()
    {
        this.controller = new EntityController();
    }

    public void Run()
    {
        int n = int.Parse(Console.ReadLine());
        string input = String.Empty;

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();

            string[] commandArgs = input.Split(' ');

            CommandInterpreter(commandArgs);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            controller.BuyFood(input);
        }

        Console.WriteLine(controller.TotalFoodPurchased());
    }

    private void CommandInterpreter(string[] commandArgs)
    {
        string name = commandArgs[0];
        int age = int.Parse(commandArgs[1]);

        if (commandArgs.Length == 4)
        {
            controller.NewPerson(name, age, commandArgs[2], commandArgs[3]);
        }
        else
        {
            controller.NewRebel(name, age, commandArgs[2]);
        }
    }
}