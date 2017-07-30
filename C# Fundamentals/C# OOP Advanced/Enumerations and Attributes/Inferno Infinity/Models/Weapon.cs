using System;

[MyClass(author: "Pesho", revision: 3, description: "Used for C# OOP Advanced Course - Enumerations and Attributes."
    , reviewers: "Pesho, Svetlio")]
public abstract class Weapon : IWeapon
{
    private string name;
    private int minDamage;
    private int maxDamage;
    private object quality;
    private int strength;
    private int agility;
    private int vitality;
    private Gem[] sockets;

    public Weapon(string name, string quality, int numberOfSockets)
    {
        this.Name = name;

        this.Quality = Enum.Parse(typeof(WeaponQuality), quality);

        this.sockets = new Gem[numberOfSockets];
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public int MinDamage
    {
        get { return this.minDamage + this.GemMinDamageBonus(); }
        protected set
        {
            this.minDamage = value * (int)this.Quality;
        }
    }

    public int MaxDamage
    {
        get { return this.maxDamage + this.GemMaxDamageBonus(); }
        protected set
        {
            this.maxDamage = value * (int)this.Quality;
        }
    }

    public object Quality
    {
        get { return this.quality; }
        protected set { this.quality = value; }
    }

    public void AddSocket(int socketIndex, Gem gem)
    {
        this.sockets[socketIndex] = gem;
    }

    public void RemoveSocket(int socketIndex)
    {
        this.sockets[socketIndex] = null;
    }

    private void ApplyBonus()
    {
        this.strength = 0;
        this.agility = 0;
        this.vitality = 0;

        foreach (var gem in this.sockets)
        {
            if (gem != null)
            {
                this.strength += gem.Strength;
                this.agility += gem.Agility;
                this.vitality += gem.Vitality;
            }
        }
    }

    private int GemMinDamageBonus()
    {
        return this.strength * 2 + this.agility * 1;
    }

    private int GemMaxDamageBonus()
    {
        return this.strength * 3 + this.agility * 4;
    }

    public override string ToString()
    {
        this.ApplyBonus();

        return $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.strength} Strength, +{this.agility} Agility, +{this.vitality} Vitality";
    }
}