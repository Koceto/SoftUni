using System;
using System.Text;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corps;

    public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get { return this.corps; }
        set
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException("Invalid corps type!");
            }
            this.corps = value;
        }
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine(base.ToString())
            .AppendLine($"Corps: {this.Corps}");

        return info.ToString().Trim();
    }
}