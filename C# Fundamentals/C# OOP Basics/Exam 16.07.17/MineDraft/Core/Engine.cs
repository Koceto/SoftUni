using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager draftManager;

    public Engine()
    {
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        while (true)
        {
            string input = Console.ReadLine();
            string[] commandsArgs = input.Split(' ');

            CommandInterpreter(commandsArgs.ToList());

            if (commandsArgs[0] == "Shutdown")
            {
                return;
            }
        }
    }

    private void CommandInterpreter(List<string> commandsArgs)
    {
        string command = commandsArgs[0];
        List<string> args = commandsArgs.Skip(1).ToList();

        switch (command)
        {
            case "RegisterHarvester":
                Console.WriteLine(draftManager.RegisterHarvester(args));
                break;

            case "RegisterProvider":
                Console.WriteLine(draftManager.RegisterProvider(args));
                break;

            case "Day":
                Console.WriteLine(draftManager.Day());
                break;

            case "Mode":
                Console.WriteLine(draftManager.Mode(args));
                break;

            case "Check":
                Console.WriteLine(draftManager.Check(args));
                break;

            case "Shutdown":
                Console.WriteLine(draftManager.ShutDown());
                break;
        }
    }
}