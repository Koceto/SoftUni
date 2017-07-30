public class Axe : Weapon
{
    public int minDamage = 5;
    public int maxDamage = 10;

    public Axe(string name, string quality)
        : base(name, quality, numberOfSockets: 4)
    {
        base.MinDamage = this.minDamage;
        base.MaxDamage = this.maxDamage;
    }
}