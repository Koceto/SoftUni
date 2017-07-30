public class GemFactory
{
    public Gem Create(string gem)
    {
        Gem newGem = null;
        string[] gemInfo = gem.Split(' ');
        string quality = gemInfo[0];
        string type = gemInfo[1];

        switch (type.ToLower())
        {
            case "ruby":
                newGem = new Ruby(quality);
                break;

            case "emerald":
                newGem = new Emerald(quality);
                break;

            case "amethyst":
                newGem = new Amethyst(quality);
                break;
        }

        return newGem;
    }
}