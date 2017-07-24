public class Person : Entity
{
    public Person(string name, int age, string id) : base(name, id)
    {
        this.Age = age;
    }

    public int Age { get; private set; }
}