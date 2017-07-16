public class MonumentFactory
{
    public Monument Create(string type, string name, int affinity)
    {
        Monument newMonument = null;

        switch (type)
        {
            case "Air":
                newMonument = new AirMonument(name, affinity);
                break;

            case "Water":
                newMonument = new WaterMonument(name, affinity);
                break;

            case "Earth":
                newMonument = new EarthMonument(name, affinity);
                break;

            case "Fire":
                newMonument = new FireMonument(name, affinity);
                break;
        }

        return newMonument;
    }
}