using System;

public class Tiger : Felime
{
    public Tiger(string name, double weight, string region, string animalType) : base(name, weight, region, animalType)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAAR!!!");
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Meat")
        {
            throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
        }

        this.FoodEaten += food.Quantity;
    }
}