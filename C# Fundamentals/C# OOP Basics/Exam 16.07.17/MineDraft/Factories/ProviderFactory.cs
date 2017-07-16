using System.Collections.Generic;

public class ProviderFactory
{
    public Provider Create(List<string> arguments)
    {
        Provider newProvider = null;

        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);

        switch (type)
        {
            case "Solar":
                newProvider = new SolarProvider(id, energyOutput);
                break;

            case "Pressure":
                newProvider = new PressureProvider(id, energyOutput);
                break;
        }

        return newProvider;
    }
}