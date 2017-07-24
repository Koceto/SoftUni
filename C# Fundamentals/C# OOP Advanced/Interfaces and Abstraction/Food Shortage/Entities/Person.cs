public class Person : IBuyer
{
    public Person(string name, string id, string birthDate, int age)
    {
        this.Name = name;
        this.ID = id;
        this.BirthDate = birthDate;
        this.Age = age;
        this.Food = 0;
    }

    public string Name { get; private set; }
    public string ID { get; private set; }
    public string BirthDate { get; private set; }
    public int Age { get; private set; }
    public int Food { get; private set; }

    public void BuyFood()
    {
        this.Food += 10;
    }
}