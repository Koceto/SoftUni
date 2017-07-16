﻿using System.Text;

public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public abstract double TotalPower();

    public abstract string BenderSpecialty();

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.Append($"{this.Name}, Power: {this.Power}, {this.BenderSpecialty()}");

        return info.ToString();
    }
}