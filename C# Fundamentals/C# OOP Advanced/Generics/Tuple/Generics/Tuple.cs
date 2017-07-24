public class Tuple<TFirst, TSecond>
{
    private TFirst first;
    private TSecond second;

    public Tuple(TFirst first, TSecond second)
    {
        this.First = first;
        this.Second = second;
    }

    public TSecond Second
    {
        get { return this.second; }
        private set { this.second = value; }
    }

    public TFirst First
    {
        get { return this.first; }
        private set { this.first = value; }
    }

    public override string ToString()
    {
        return $"{this.First} -> {this.Second}";
    }
}