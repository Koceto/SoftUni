using System;

public class Engine
{
    private CarManager carManager;

    public Engine()
    {
        carManager = new CarManager();
    }

    public void Run()
    {
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            string[] commandArgs = input.Split(' ');
            ExecuteCommand(commandArgs);
        }
    }

    private void ExecuteCommand(string[] commandArgs)
    {
        int id = int.Parse(commandArgs[1]);

        switch (commandArgs[0].ToLower())
        {
            case "register":
                string vehicleType = commandArgs[2];
                string brand = commandArgs[3];
                string model = commandArgs[4];
                int yearOfProduction = int.Parse(commandArgs[5]);
                int horsepower = int.Parse(commandArgs[6]);
                int acceleration = int.Parse(commandArgs[7]);
                int suspension = int.Parse(commandArgs[8]);
                int durability = int.Parse(commandArgs[9]);

                this.carManager.Register(id, vehicleType, brand, model, yearOfProduction, horsepower, acceleration, suspension,
                    durability);
                break;

            case "check":

                Console.WriteLine(this.carManager.Check(id));
                break;

            case "open":
                string type = commandArgs[2];
                int length = int.Parse(commandArgs[3]);
                string route = commandArgs[4];
                int prizePool = int.Parse(commandArgs[5]);

                this.carManager.Open(id, type, length, route, prizePool);
                break;

            case "participate":
                int raceId = int.Parse(commandArgs[2]);

                this.carManager.Participate(id, raceId);
                break;

            case "start":
                Console.WriteLine(this.carManager.Start(id));
                break;

            case "park":
                this.carManager.Park(id);
                break;

            case "unpark":
                this.carManager.Unpark(id);
                break;

            case "tune":
                string addOn = commandArgs[2];
                this.carManager.Tune(id, addOn);
                break;
        }
    }
}