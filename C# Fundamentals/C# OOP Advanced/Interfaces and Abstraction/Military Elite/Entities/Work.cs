public class Work
{
    public Work(string partName, int hours)
    {
        this.PartName = partName;
        this.Hours = hours;
    }

    public string PartName { get; private set; }
    public int Hours { get; private set; }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.Hours}";
    }
}