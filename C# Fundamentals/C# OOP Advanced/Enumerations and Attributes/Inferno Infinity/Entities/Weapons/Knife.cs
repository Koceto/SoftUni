public class Knife : Weapon
{
    private int minDamage = 3;
    private int maxDamage = 4;

    public Knife(string name, string quality)
        : base(name, quality, numberOfSockets: 2)
    {
        base.MinDamage = this.minDamage;
        base.MaxDamage = this.maxDamage;
    }
}