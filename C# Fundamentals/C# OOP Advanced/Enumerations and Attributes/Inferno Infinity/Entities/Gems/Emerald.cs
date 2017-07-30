public class Emerald : Gem
{
    private int strength = 1;
    private int agility = 4;
    private int vitality = 9;

    public Emerald(string quality)
        : base(quality)
    {
        base.Strength = this.strength;
        base.Agility = this.agility;
        base.Vitality = this.vitality;
    }
}