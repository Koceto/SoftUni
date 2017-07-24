public class Robot : IEntity
{
    public Robot(string name, string id)
    {
        this.Name = name;
        this.ID = id;
        this.BirthDate = "n/a";
        this.Age = 0;
    }

    public string Name { get; private set; }
    public string ID { get; private set; }
    public string BirthDate { get; private set; }
    public int Age { get; private set; }
}