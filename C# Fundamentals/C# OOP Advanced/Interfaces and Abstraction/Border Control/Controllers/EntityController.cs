using System;
using System.Collections.Generic;

public class EntityController
{
    private List<IEntity> entities;

    public EntityController()
    {
        this.entities = new List<IEntity>();
    }

    public void NewRobot(string name, string id)
    {
        this.entities.Add(new Robot(name, id));
    }

    public void NewPerson(string name, int age, string id)
    {
        this.entities.Add(new Person(name, age, id));
    }

    public void FindFalseIDs(string falseIDs)
    {
        foreach (var entity in this.entities)
        {
            if (entity.ID.EndsWith(falseIDs))
            {
                Console.WriteLine(entity.ID);
            }
        }
    }
}