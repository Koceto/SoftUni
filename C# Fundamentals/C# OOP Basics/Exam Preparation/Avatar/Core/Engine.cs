using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Quit")
        {
            string[] commandArgs = input.Split(' ');
            CommandInterpreter(commandArgs.ToList());
        }

        Console.WriteLine(nationsBuilder.GetWarsRecord());
    }

    private void CommandInterpreter(List<string> commandArgs)
    {
        string command = commandArgs[0].ToLower();

        if (command == "bender")
        {
            nationsBuilder.AssignBender(commandArgs);
        }
        else if (command == "monument")
        {
            nationsBuilder.AssignMonument(commandArgs);
        }
        else if (command == "status")
        {
            Console.WriteLine(nationsBuilder.GetStatus(commandArgs[1]));
        }
        else if (command == "war")
        {
            nationsBuilder.IssueWar(commandArgs[1]);
        }
    }
}