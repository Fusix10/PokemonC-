using System;
using System.Collections.Generic;

class Entity
{
    public int Id { get; private set; }

    public Entity(int id)
    {
        Id = id;
    }

    public virtual void Update()
    {
        Console.WriteLine($"Entity {Id} is updating...");
    }
}