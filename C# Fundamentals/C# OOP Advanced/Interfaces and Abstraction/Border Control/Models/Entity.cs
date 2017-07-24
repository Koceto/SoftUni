public abstract class Entity : IEntity
{
    protected Entity(string name, string id)
    {
        this.Name = name;
        this.ID = id;
    }

    public string Name { get; private set; }
    public string ID { get; private set; }
}