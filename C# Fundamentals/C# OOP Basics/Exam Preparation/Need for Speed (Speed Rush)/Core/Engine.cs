using System;

public class Engine
{
    private CarManager carManager;

    public Engine()
    {
        this.carManager = new CarManager();
    }

    public void Run()
    {
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            string[] commandArgs = input.Split(' ');
            CommandInterpreter(commandArgs);
        }
    }

    private void CommandInterpreter(string[] commandArgs)
    {
        string command = commandArgs[0];
        int id = int.Parse(commandArgs[1]);

        switch (command)
        {
            case "register":
                string carType = commandArgs[2];
                string brand = commandArgs[3];
                string model = commandArgs[4];
                int year = int.Parse(commandArgs[5]);
                int horsePower = int.Parse(commandArgs[6]);
                int acceleration = int.Parse(commandArgs[7]);
                int suspension = int.Parse(commandArgs[8]);
                int durability = int.Parse(commandArgs[9]);

                carManager.Register(id, carType, brand, model, year, horsePower, acceleration, suspension, durability);
                break;

            case "check":
                Console.WriteLine(carManager.Check(id));
                break;

            case "open":
                string raceType = commandArgs[2];
                string route = commandArgs[4];
                int length = int.Parse(commandArgs[3]);
                int prize = int.Parse(commandArgs[5]);
                int specialRaceModifier = default(int);

                if (commandArgs.Length == 7)
                {
                    specialRaceModifier = int.Parse(commandArgs[6]);
                }

                carManager.Open(id, raceType, length, route, prize, specialRaceModifier);
                break;

            case "participate":
                int raceId = int.Parse(commandArgs[2]);

                carManager.Participate(id, raceId);
                break;

            case "start":
                
                    Console.WriteLine(carManager.Start(id));
                
                break;

            case "park":
                carManager.Park(id);
                break;

            case "unpark":
                carManager.Unpark(id);
                break;

            case "tune":
                int tuneIndex = int.Parse(commandArgs[1]);
                string addOn = commandArgs[2];

                carManager.Tune(tuneIndex, addOn);
                break;
        }
    }
}