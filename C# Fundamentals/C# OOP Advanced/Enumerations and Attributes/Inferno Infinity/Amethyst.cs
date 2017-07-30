public class Amethyst : Gem
{
    private int strength = 2;
    private int agility = 8;
    private int vitality = 4;

    public Amethyst(string quality)
        : base(quality)
    {
        base.Strength = this.strength;
        base.Agility = this.agility;
        base.Vitality = this.vitality;
    }
}