using System.Collections.Generic;
using System.Linq;

public class EntityController
{
    private List<IBuyer> entities;

    public EntityController()
    {
        this.entities = new List<IBuyer>();
    }

    public void NewPerson(string name, int age, string personId, string personBirthDate)
    {
        this.entities.Add(new Person(name, personId, personBirthDate, age));
    }

    public void NewRebel(string name, int age, string group)
    {
        this.entities.Add(new Rebel(name, age, group));
    }

    public void BuyFood(string name)
    {
        IBuyer currentEntity = this.entities.FirstOrDefault(e => e.Name == name);

        if (currentEntity != null)
        {
            currentEntity.BuyFood();
        }
    }

    public int TotalFoodPurchased()
    {
        return this.entities.Select(e => e.Food).Sum();
    }
}