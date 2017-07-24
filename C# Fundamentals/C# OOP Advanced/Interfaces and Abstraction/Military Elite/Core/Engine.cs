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
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] commandArgs = input.Split(' ');

            controller.NewSoldier(commandArgs);
        }

        controller.Print();
    }
}