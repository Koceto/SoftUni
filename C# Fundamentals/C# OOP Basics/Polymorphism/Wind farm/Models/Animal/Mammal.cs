public abstract class Mammal : Animal
{
    private string region;

    public Mammal(string name, double weight, string region, string animalType) : base(name, weight, animalType)
    {
        this.Region = region;
    }

    public string Region
    {
        get { return this.region; }
        set { this.region = value; }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.AnimalName}, {this.Weight}, {this.Region}, {this.FoodEaten}]";
    }
}