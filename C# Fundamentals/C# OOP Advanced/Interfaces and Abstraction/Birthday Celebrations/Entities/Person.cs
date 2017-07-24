public class Person : IEntity
{
    public Person(string name, string id, string birthDate, int age)
    {
        this.Name = name;
        this.ID = id;
        this.BirthDate = birthDate;
        this.Age = age;
    }

    public string Name { get; private set; }
    public string ID { get; private set; }
    public string BirthDate { get; private set; }
    public int Age { get; private set; }
}