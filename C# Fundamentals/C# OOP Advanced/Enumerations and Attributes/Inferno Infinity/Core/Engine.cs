using System;
using System.Linq;

public class Engine
{
    private Controller controller;

    public Engine()
    {
        this.controller = new Controller();
    }

    public void Run()
    {
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] commandArgs = input.Split(';');

            CommandInterpreter(commandArgs);
        }
    }

    private void CommandInterpreter(string[] commandArgs)
    {
        string command = commandArgs[0];
        string weaponName = String.Empty;
        int socketIndex = 0;
        var attributes = typeof(Weapon).GetCustomAttributes(false);
        MyClassAttribute typeAttribute = attributes.ToArray()[0] as MyClassAttribute;


        switch (command.ToLower())
        {
            case "create":
                string weaponInfo = commandArgs[1];
                weaponName = commandArgs[2];

                this.controller.CreateWeapon(weaponInfo, weaponName);
                break;

            case "add":
                weaponName = commandArgs[1];
                socketIndex = int.Parse(commandArgs[2]);
                string gemInfo = commandArgs[3];

                this.controller.Add(weaponName, socketIndex, gemInfo);
                break;

            case "remove":
                weaponName = commandArgs[1];
                socketIndex = int.Parse(commandArgs[2]);

                this.controller.Remove(weaponName, socketIndex);
                break;

            case "print":
                weaponName = commandArgs[1];

                this.controller.Print(weaponName);
                break;

            case "author":
                Console.WriteLine($"Author: {typeAttribute.Author}");
                break;

            case "revision":
                Console.WriteLine($"Revision: {typeAttribute.Revision}");
                break;

            case "description":
                Console.WriteLine($"Class description: {typeAttribute.Description}");
                break;

            case "reviewers":
                Console.WriteLine($"Reviewers: {typeAttribute.Reviewers}");
                break;
        }
    }
}