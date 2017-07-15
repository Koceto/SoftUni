using System;

public class Cat : Felime
{
    private string type;

    public Cat(string name, double weight, string region, string type, string animalType) : base(name, weight, region, animalType)
    {
        this.Type = type;
    }

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meowwww");
    }

    public override void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.AnimalName}, {this.Type}, {this.Weight}, {this.Region}, {this.FoodEaten}]";
    }
}