using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester Create(List<string> arguments)
    {
        Harvester newHarvester = null;

        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = Double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);

        switch (type)
        {
            case "Sonic":
                int sonicFactor = int.Parse(arguments[4]);
                newHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                break;

            case "Hammer":
                newHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
                break;
        }

        return newHarvester;
    }
}