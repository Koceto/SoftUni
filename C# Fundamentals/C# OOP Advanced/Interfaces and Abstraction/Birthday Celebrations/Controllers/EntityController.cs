using System;
using System.Collections.Generic;

public class EntityController
{
    private List<IEntity> entities;

    public EntityController()
    {
        this.entities = new List<IEntity>();
    }

    public void NewPet(string name, string petBirthDate)
    {
        this.entities.Add(new Pet(name, petBirthDate));
    }

    public void NewRobot(string name, string robotId)
    {
        this.entities.Add(new Robot(name, robotId));
    }

    public void NewPerson(string name, int age, string personId, string personBirthDate)
    {
        this.entities.Add(new Person(name, personId, personBirthDate, age));
    }

    public void FindEntities(string yearToPrint)
    {
        foreach (var entity in this.entities)
        {
            if (entity.BirthDate.EndsWith(yearToPrint))
            {
                Console.WriteLine(entity.BirthDate);
            }
        }
    }
}