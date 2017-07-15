public class AnimalFactory
{
    public Animal Create(string name, double weight, string region, string animalType, string catBreed)
    {
        Animal animal = null;

        switch (animalType)
        {
            case "Zebra":
                animal = new Zebra(name, weight, region, animalType);
                break;

            case "Mouse":
                animal = new Mouse(name, weight, region, animalType);
                break;

            case "Tiger":
                animal = new Tiger(name, weight, region, animalType);
                break;

            case "Cat":
                animal = new Cat(name, weight, region, catBreed, animalType);
                break;
        }

        return animal;
    }
}