using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private AnimalFactory animalFactory;
    private FoodFactory foodFactory;
    private List<Animal> zoo;

    public Engine()
    {
        this.animalFactory = new AnimalFactory();
        this.zoo = new List<Animal>();
        this.foodFactory = new FoodFactory();
    }

    public void Run()
    {
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] animalInfo = input.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Animal animal = GetAnimal(animalInfo);

            input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            string[] foodInfo = input.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Food food = foodFactory.Create(foodInfo);

            animal.MakeSound();
            Feed(animal, food);
            Console.WriteLine(animal);
        }
    }

    private Animal GetAnimal(string[] animalInfo)
    {
        string animalType = animalInfo[0];
        string animalName = animalInfo[1];
        double animalWeight = double.Parse(animalInfo[2]);
        string animalRegion = animalInfo[3];
        string catType = string.Empty;

        if (animalInfo.Length == 5)
        {
            catType = animalInfo[4];
        }

        Animal animal = this.zoo.FirstOrDefault(a => a.AnimalName == animalName && a.AnimalType == animalType);

        if (animal == null)
        {
            animal = this.animalFactory.Create(animalName, animalWeight, animalRegion, animalType, catType);
            this.zoo.Add(animal);
        }

        return animal;
    }

    private void Feed(Animal animal, Food food)
    {
        try
        {
            animal.Eat(food);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}