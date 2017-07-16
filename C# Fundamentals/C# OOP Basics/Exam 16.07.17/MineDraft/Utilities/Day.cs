using System.Collections.Generic;
using System.Linq;

public class Day
{
    public double GetEnergyProvided(Dictionary<string, Provider> allProviders)
    {
        double energy = 0;

        foreach (var provider in allProviders.Values)
        {
            energy += provider.EnergyOutput;
        }

        return energy;
    }

    public double[] GetHarvestedOre(Dictionary<string, Harvester> allHarvesters, double totalEnergy, string mode)
    {
        double[] result = new double[2];
        double oreProduced = 0;
        double energyUsed = 0;
        double productionModifier = 0;
        double energyModifier = 0;

        switch (mode)
        {
            case "Full":
                productionModifier = 1;
                energyModifier = 1;
                break;

            case "Half":
                productionModifier = 0.5;
                energyModifier = 0.6;
                break;

            case "Energy":
                productionModifier = 0;
                energyModifier = 0;
                break;
        }

        double energyRequired = allHarvesters.Values.Select(h => h.EnergyRequirement * energyModifier).Sum();

        if (energyRequired <= totalEnergy && productionModifier > 0)
        {
            foreach (var harvester in allHarvesters.Values)
            {
                oreProduced += harvester.OreOutput * productionModifier;
                energyUsed += harvester.EnergyRequirement * energyModifier;
            }
        }

        result[0] = oreProduced;
        result[1] = energyUsed;

        return result;
    }
}