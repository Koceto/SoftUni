using System.Text;

public class Spy : Soldier, ISpy
{
    public Spy(string id, string firstName, string lastName, int number) : base(id, firstName, lastName)
    {
        this.Number = number;
    }

    public int Number { get; private set; }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID}")
            .AppendLine($"Code Number: {this.Number}");

        return info.ToString().Trim();
    }
}