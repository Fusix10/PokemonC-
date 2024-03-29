



using ConsoleApp1;
using System.Numerics;

public class IA_Combat
{
    List<Pokemon> pokemons;
    List<Pokemon> ennemies;


    public IA_Combat(List<Pokemon> pokemon, List<Pokemon> ennemies)
    {
        this.pokemons = pokemon;
        this.ennemies = ennemies;
    }



    public void Round()
    {
        foreach(var pokemon in pokemons)
        {
            if (CheckAttack(pokemon, out Vector2 pos))
            {
                Engine.instance.Window1.Windowfigth1[(int)pos.X][(int)pos.Y].Pok.TakeDommage(pokemon.Dmg);


                continue;
            }

            if (FindMove(pokemon, out pos))
            {
                pokemon.P.X = (int)pos.X;
                pokemon.P.Y = (int)pos.Y;


                continue;
            }
        }
    }



    private bool CheckAttack(Pokemon pokemon, out Vector2 position)
    {
        position = new(-1, -1);
        foreach (var move in pokemon.ViewAttackResult)
        {
            foreach (var ennemie in ennemies)
            {
                if (ennemie.P.X == move[0] && ennemie.P.Y == move[1])
                {
                    position = new(pokemon.P.X + move[0], pokemon.P.Y + move[1]);
                }
            }
        }

        if (position.X == -1)
        {
            position = Vector2.Zero;
            return false;
        }

        return true;
    }


    private bool FindMove(Pokemon pokemon, out Vector2 position)
    {
        position = new(-1, -1);
        foreach (var move in pokemon.ViewMoveResult1)
        {
            position = new(pokemon.P.X + move[0], pokemon.P.Y + move[1]);
        }

        if (position.X == -1)
        {
            position = Vector2.Zero;
            return false;
        }

        return true;
    }
}   