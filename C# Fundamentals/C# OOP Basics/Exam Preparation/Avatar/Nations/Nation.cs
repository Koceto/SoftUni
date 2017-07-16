using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;
    private string type;

    public Nation(string type)
    {
        this.Type = type;
        this.Benders = new List<Bender>();
        this.Monuments = new List<Monument>();
    }

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public double TotalPower
    {
        get
        {
            double power = default(double);

            foreach (var bender in this.Benders)
            {
                power += bender.TotalPower();
            }

            if (this.Monuments.Count != 0)
            {
                int monumentBonus = this.Monuments.Select(m => m.GetPower()).Sum();
                power = power * monumentBonus / 100;
            }

            return power;
        }
    }

    public List<Monument> Monuments
    {
        get { return this.monuments; }
        private set { this.monuments = value; }
    }

    public List<Bender> Benders
    {
        get { return this.benders; }
        private set { this.benders = value; }
    }

    public void AssignBender(Bender bender)
    {
        this.Benders.Add(bender);
    }

    public void AssignMonument(Monument monument)
    {
        this.Monuments.Add(monument);
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"{this.Type} Nation")
            .AppendLine(GetBenders())
            .AppendLine(GetMonuments());

        return info.ToString().Trim();
    }

    public string GetBenders()
    {
        StringBuilder info = new StringBuilder();

        info.Append($"Benders: ");

        if (this.Benders.Count == 0)
        {
            info.Append("None");
        }
        else
        {
            info.AppendLine();
        }

        foreach (var bender in this.Benders)
        {
            info.AppendLine($"###{this.Type} Bender: {bender}");
        }

        return info.ToString().Trim();
    }

    private string GetMonuments()
    {
        StringBuilder info = new StringBuilder();

        info.Append($"Monuments: ");

        if (this.Monuments.Count == 0)
        {
            info.Append("None");
        }
        else
        {
            info.AppendLine();
        }

        foreach (var monument in this.Monuments)
        {
            info.AppendLine($"###{this.Type} Monument: {monument}");
        }

        return info.ToString().Trim();
    }

    public void Defeat()
    {
        this.Benders.Clear();
        this.Monuments.Clear();
    }
}