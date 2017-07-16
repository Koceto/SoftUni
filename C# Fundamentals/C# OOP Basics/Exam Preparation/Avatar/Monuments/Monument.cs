using System.Text;

public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public abstract int GetPower();

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.Append($"{this.Name}, {this.GetSpecialty()}");

        return info.ToString();
    }

    public abstract string GetSpecialty();
}