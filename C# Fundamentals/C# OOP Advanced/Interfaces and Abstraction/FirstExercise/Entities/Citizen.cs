public class Citizen : IPerson, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdata)
    {
        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.Birthdata = birthdata;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
    public string ID { get; private set; }
    public string Birthdata { get; private set; }
}