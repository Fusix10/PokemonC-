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
        entity.SetEntityManager(this); // Permet à l'entité de connaître son EntityManager
    }

    public void RemoveEntity(Entity entity)
    {
        entities.Remove(entity);
    }

    public void UpdateEntities()
    {
        foreach (Entity entity in entities)
        {
            entity.Update();
        }
    }
}

class Entity
{
    protected EntityManager entityManager;

    public void SetEntityManager(EntityManager manager)
    {
        entityManager = manager;
    }

    public virtual void Update()
    {
        Console.WriteLine("Entity updating...");
    }
}