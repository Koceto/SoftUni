public class BenderFactory
{
    public Bender Create(string type, string name, int power, double affinity)
    {
        Bender newBender = null;

        switch (type)
        {
            case "Air":
                newBender = new AirBender(name, power, affinity);
                break;

            case "Water":
                newBender = new WaterBender(name, power, affinity);
                break;

            case "Earth":
                newBender = new EarthBender(name, power, affinity);
                break;

            case "Fire":
                newBender = new FireBender(name, power, affinity);
                break;
        }

        return newBender;
    }
}