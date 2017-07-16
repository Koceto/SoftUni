public abstract class Robot
{
    private string id;

    protected Robot(string id)
    {
        this.ID = id;
    }

    public string ID
    {
        get { return this.id; }
        protected set { this.id = value; }
    }
}