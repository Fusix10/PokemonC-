using System;
using System.Collections.Generic;

class EntityManager
{
    private List<Entity> entities;

    public EntityManager()
    {
        entities = new List<Entity>();
    }

    public void AddEntity(Entity entity)
    {
        entities.Add(entity);
    }

    public void RemoveEntity(Entity entity)
    {
        entities.Remove(entity);
    }

    public void Update()
    {
        foreach (Entity entity in entities)
        {
            entity.Update();
        }
    }
}

