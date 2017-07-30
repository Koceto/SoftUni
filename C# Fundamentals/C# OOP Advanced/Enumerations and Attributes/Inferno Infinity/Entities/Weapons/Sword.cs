public class Sword : Weapon
{
    private int minDamage = 4;
    private int maxDamage = 6;

    public Sword(string name, string quality)
        : base(name, quality, numberOfSockets: 3)
    {
        base.MinDamage = this.minDamage;
        base.MaxDamage = this.maxDamage;
    }
}