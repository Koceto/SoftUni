using System;
using System.Collections.Generic;
using System.Linq;

public class EntityController
{
    private List<ISoldier> soldiers;

    public EntityController()
    {
        this.soldiers = new List<ISoldier>();
    }

    public void NewSoldier(string[] commandArgs)
    {
        ISoldier newSoldier = null;

        string command = commandArgs[0];
        string id = commandArgs[1];
        string firstName = commandArgs[2];
        string lastName = commandArgs[3];
        double salary = double.Parse(commandArgs[4]);
        string corps;

        try
        {
            switch (command)
            {
                case "Private":
                    newSoldier = new Private(id, firstName, lastName, salary);
                    break;

                case "LeutenantGeneral":
                    newSoldier = new LeutenantGeneral(id, firstName, lastName, salary, GetSoldiers(commandArgs.Skip(5).ToArray()));
                    break;

                case "Engineer":
                    corps = commandArgs[5];

                    newSoldier = new Engineer(id, firstName, lastName, salary, corps, GetWorks(commandArgs.Skip(6).ToArray()));
                    break;

                case "Commando":
                    corps = commandArgs[5];

                    newSoldier = new Commando(id, firstName, lastName, salary, corps, GetMissions(commandArgs.Skip(6).ToArray()));
                    break;

                case "Spy":
                    int number = int.Parse(commandArgs[4]);

                    newSoldier = new Spy(id, firstName, lastName, number);
                    break;
            }
        }
        catch (ArgumentException)
        {
        }

        this.soldiers.Add(newSoldier);
    }

    private List<Mission> GetMissions(string[] missionInfo)
    {
        List<Mission> missions = new List<Mission>();

        for (int i = 0; i < missionInfo.Length; i += 2)
        {
            try
            {
                Mission current = new Mission(missionInfo[i], missionInfo[i + 1]);
                missions.Add(current);
            }
            catch (ArgumentException)
            {
            }
        }

        return missions;
    }

    private List<Work> GetWorks(string[] workInfo)
    {
        List<Work> works = new List<Work>();

        for (int i = 0; i < workInfo.Length; i += 2)
        {
            Work current = new Work(workInfo[i], int.Parse(workInfo[i + 1]));

            works.Add(current);
        }

        return works;
    }

    private List<ISoldier> GetSoldiers(string[] soldierIDs)
    {
        List<ISoldier> soldiers = new List<ISoldier>();

        foreach (var id in soldierIDs)
        {
            soldiers.Add(this.soldiers.FirstOrDefault(s => s.ID == id));
        }

        return soldiers;
    }

    public void Print()
    {
        foreach (var soldier in this.soldiers)
        {
            Console.WriteLine(soldier);
        }
    }
}