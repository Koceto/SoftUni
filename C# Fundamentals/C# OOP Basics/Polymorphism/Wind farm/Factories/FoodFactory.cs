public class FoodFactory
{
    public Food Create(string[] foodInfo)
    {
        Food food = null;

        if (foodInfo[0] == "Meat")
        {
            food = new Meat(int.Parse(foodInfo[1]));
        }
        else if (foodInfo[0] == "Vegetable")
        {
            food = new Vegetable(int.Parse(foodInfo[1]));
        }

        return food;
    }
}