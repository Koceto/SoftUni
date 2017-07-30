public class Ruby : Gem
{
    private int strength = 7;
    private int agility = 2;
    private int vitality = 5;

    public Ruby(string quality)
        : base(quality)
    {
        base.Strength = this.strength;
        base.Agility = this.agility;
        base.Vitality = this.vitality;
    }
}