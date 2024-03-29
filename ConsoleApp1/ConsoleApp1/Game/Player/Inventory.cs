using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

internal class Inventory
{
    List<List<Pokemon>> Pokedex;
    List<Pokemon> InvActuel;
    public List<List<Pokemon>> Pokedex1 { get => Pokedex;}
    public List<Pokemon> InvActuel1 { get => InvActuel; set => InvActuel = value; }
    public Inventory()
    {
        Pokedex = new List<List<Pokemon>>();
        InvActuel = new List<Pokemon>();
    }
    public void AddPokemon(Pokemon Poke)
    {
        
        for (int j = 0; j < Pokedex.Count(); j++)
        {
            if (Pokedex[j][0].Id == Poke.Id)
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
                if(Pokedex[j][0].Id == Poke[i].Id) 
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
    public void AddPokemonInvActuel(Pokemon Poke)
    {
        InvActuel.Add(Poke);
    }
    public void AddPokemonInvActuel(List<Pokemon> Poke)
    {
        for(int i = 0;i < Poke.Count(); i++)
        {
            InvActuel.Add(Poke[i]);
        }
    }
}

