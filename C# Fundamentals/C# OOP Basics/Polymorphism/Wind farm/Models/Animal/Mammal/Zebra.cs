using System;

public class Zebra : Mammal
{
    public Zebra(string name, double weight, string region, string animalType) : base(name, weight, region, animalType)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Zs");
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Vegetable")
        {
            throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
        }

        this.FoodEaten += food.Quantity;
    }
}