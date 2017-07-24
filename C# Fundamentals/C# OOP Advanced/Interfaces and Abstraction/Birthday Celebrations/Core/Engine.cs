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

            CommandInterpreter(commandArgs);
        }

        string yearToPrint = Console.ReadLine();

        controller.FindEntities(yearToPrint);
    }

    private void CommandInterpreter(string[] commandArgs)
    {
        string command = commandArgs[0];
        string name = commandArgs[1];

        switch (command)
        {
            case "Citizen":
                int age = int.Parse(commandArgs[2]);
                string personId = commandArgs[3];
                string personBirthDate = commandArgs[4];

                controller.NewPerson(name, age, personId, personBirthDate);
                break;

            case "Pet":
                string petBirthDate = commandArgs[2];

                controller.NewPet(name, petBirthDate);
                break;

            case "Robot":
                string robotId = commandArgs[2];

                controller.NewRobot(name, robotId);
                break;
        }
    }
}