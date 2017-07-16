using System;
using System.Collections.Generic;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> allHarvesters;
    private Dictionary<string, Provider> allProviders;
    private double totalEnergy;
    private double totalOre;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;
    private string mode;

    public DraftManager()
    {
        this.allHarvesters = new Dictionary<string, Harvester>();
        this.allProviders = new Dictionary<string, Provider>();
        this.totalEnergy = 0;
        this.totalOre = 0;
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester newHarvester = this.harvesterFactory.Create(arguments);

            string id = arguments[1];
            this.allHarvesters.Add(id, newHarvester);

            return $"Successfully registered {newHarvester.Info()}";
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider newProvider = this.providerFactory.Create(arguments);

            string id = arguments[1];
            this.allProviders.Add(id, newProvider);

            return $"Successfully registered {newProvider.Info()}";
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }

    public string Day()
    {
        Day day = new Day();

        double energy = day.GetEnergyProvided(this.allProviders);
        this.totalEnergy += energy;

        double[] daysHarvest = day.GetHarvestedOre(this.allHarvesters, this.totalEnergy, this.mode);

        double ore = daysHarvest[0];
        double energyUsed = daysHarvest[1];

        this.totalOre += ore;
        this.totalEnergy -= energyUsed;

        StringBuilder info = new StringBuilder();

        info.AppendLine("A day has passed.")
            .AppendLine($"Energy Provided: {energy}")
            .AppendLine($"Plumbus Ore Mined: {ore}");

        return info.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        string modeType = arguments[0];
        this.mode = modeType;

        return $"Successfully changed working mode to {this.mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];

        if (this.allProviders.ContainsKey(id))
        {
            return this.allProviders[id].ToString();
        }

        if (this.allHarvesters.ContainsKey(id))
        {
            return this.allHarvesters[id].ToString();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine("System Shutdown")
            .AppendLine($"Total Energy Stored: {this.totalEnergy}")
            .AppendLine($"Total Mined Plumbus Ore: {this.totalOre}");

        return info.ToString().Trim();
    }
}