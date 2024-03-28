using System;
using System.Collections.Generic;
using System.Dynamic;
using ConsoleApp1;


public class EntityManager
{
    List<Pokemon> Team1;
    List<Pokemon> Team2;
    
    public List<Pokemon> Team11 { get => Team1; }
    public List<Pokemon> Team21 { get => Team2; }

    private void AddPok(Pokemon u, int Who)
    {
        if (Who == 1)

        {
            Team1.Add(u);
        }
        if (Who == 2)
        {
            Team2.Add(u);
        }
    }

    private void DeletePok(int i, int Who)
    {
        if (Who == 1)
        {
            Team1.Remove(Team1[i]);
        }
        
        if (Who == 2)
        {
            Team2.Remove(Team2[i]);
        }
    }



    public void RemoveEntity(EntityData entity)
    {
        entities.Remove(entity);
    }

  
  
    public void UpdateEntities()
    {
        foreach (var entity in entities)
        {
            // Mettez à jour chaque entité en fonction de son type
            switch (entity.Type)
            {
                case EntityType.Pokemon:
                    // Mettez à jour le Pokémon
                    break;
                case EntityType.Player:
                    // Mettez à jour le joueur
                    break;
            }
        }
    }
}