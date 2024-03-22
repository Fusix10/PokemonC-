using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

internal class Inventory
{
    List<List<Pokemon>> Pokedex;
    public List<List<Pokemon>> Pokedex1 { get => Pokedex;}
    public Inventory()
    {
        Pokedex = new List<List<Pokemon>>();
    }

    public void AddPokemon(Pokemon Poke)
    {
        
        for (int j = 0; j < Pokedex.Count(); j++)
        {
            if (Pokedex[j][0]._id == Poke._id)
            {
                Pokedex[j].Add(Poke);
            }
            else
            {
                List<Pokemon> PokePass = new List<Pokemon>();
                PokePass.Add(Poke);
                Pokedex.Add(PokePass);
            }
        }
    }
    public void AddPokemon(List<Pokemon> Poke)
    {
        for (int i = 0; i < Poke.Count; i++) 
        {
            for(int j = 0; j < Pokedex.Count(); j++)
            {
                if(Pokedex[j][0]._id == Poke[i]._id) 
                {
                    Pokedex[j].Add(Poke[i]);
                }
                else
                {
                    List<Pokemon> PokePass = new List<Pokemon>();
                    PokePass.Add(Poke[i]);
                    Pokedex[j].Add(PokePass[j]);
                }
            }
        }
    }
}

