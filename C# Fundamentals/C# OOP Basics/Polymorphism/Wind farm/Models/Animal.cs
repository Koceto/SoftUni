public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double weight;
    private int foodEaten;

    public Animal(string name, double weight, string animalType)
    {
        this.AnimalName = name;
        this.Weight = weight;
        this.AnimalType = animalType;
    }

    public int FoodEaten
    {
        get { return this.foodEaten; }
        set { this.foodEaten = value; }
    }

    public double Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public string AnimalName
    {
        get { return this.animalName; }
        set { this.animalName = value; }
    }

    public string AnimalType
    {
        get { return this.animalType; }
        set { this.animalType = value; }
    }

    public abstract void MakeSound();

    public abstract void Eat(Food food);
}