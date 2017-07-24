public class Threeuple<TFirst, TSecond, TThird>
{
    private TFirst first;
    private TSecond second;
    private TThird third;

    public Threeuple(TFirst first, TSecond second, TThird third)
    {
        this.First = first;
        this.Second = second;
        this.Third = third;
    }

    public TThird Third
    {
        get { return this.third; }
        private set { this.third = value; }
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
        return $"{this.First} -> {this.Second} -> {this.Third}";
    }
}