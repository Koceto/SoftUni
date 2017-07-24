public class Rebel : IBuyer
{
    public Rebel(string name, int age, string group)
    {
        this.Group = group;
        this.Name = name;
        this.ID = "n/a";
        this.BirthDate = "n/a";
        this.Age = age;
        this.Food = 0;
    }

    public string Group { get; private set; }
    public string Name { get; private set; }
    public string ID { get; private set; }
    public string BirthDate { get; private set; }
    public int Age { get; private set; }
    public int Food { get; private set; }

    public void BuyFood()
    {
        this.Food += 5;
    }
}