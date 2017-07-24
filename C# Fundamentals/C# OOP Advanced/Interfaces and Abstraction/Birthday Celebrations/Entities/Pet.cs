public class Pet : IEntity
{
    public Pet(string name, string birthDate)
    {
        this.Name = name;
        this.ID = "n/a";
        this.BirthDate = birthDate;
        this.Age = 0;
    }

    public string Name { get; private set; }
    public string ID { get; private set; }
    public string BirthDate { get; private set; }
    public int Age { get; private set; }
}