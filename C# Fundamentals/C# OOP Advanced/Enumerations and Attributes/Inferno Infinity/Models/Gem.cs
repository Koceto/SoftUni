using System;

public abstract class Gem : IGem
{
    private int strength;
    private int agility;
    private int vitality;
    private object quality;

    public Gem(string quality)
    {
        this.Quality = Enum.Parse(typeof(GemQuality), quality);
    }

    public object Quality
    {
        get { return this.quality; }
        private set { this.quality = value; }
    }

    public int Vitality
    {
        get { return this.vitality; }
        protected set { this.vitality = value + (int)this.Quality; }
    }

    public int Agility
    {
        get { return this.agility; }
        protected set { this.agility = value + (int)this.Quality; }
    }

    public int Strength
    {
        get { return this.strength; }
        protected set { this.strength = value + (int)this.Quality; }
    }
}