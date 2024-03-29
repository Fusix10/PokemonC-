using System;
using System.Collections.Generic;
using System.Drawing;

internal class Map
{
    public class CharactereDesc
    {
        public char Character { get; set; }
        public Color Color { get; set; }
        public bool CanPassThrough { get; set; }
    }

    public List<CharactereDesc> Characts { get; set; }
    public string myMap;
    public Player Player { get; set; }
    private Random random = new Random();

    public Map()
    {
        Characts = new List<CharactereDesc>();

        myMap =
        "#####################################################################################\r\n" +
        "#                        _.-'_~_-~-_~_~_`-._                                        #\r\n" +
        "#                     _.'_~-_~-_-~-_~_~-_~-_`-                                      #\r\n" +
        "#                    _.-'_~-_~-_-~-_~_~-_~-_`-._                                    #\r\n" +
        "#                      | ___     __     ___ |                                       #\r\n" +
        "#                      |[___]   | .|   [___]|                                       #\r\n" +
        "#                      |______()|__|()______|   ^^^^^^^^^^^^^^^^^^^^^^^^            #\r\n" +
        "#                                               ^^^^^^^^^^^^^^^^^^^^^^^^            #\r\n" +
        "#                                               ^^^^^^^^^^^^^^^^^^^^^^^^            #\r\n" +
        "#                                               ^^^^^^^^^^^^^^^^^^^^^^^^            #\r\n" +
        "#                                               ^^^^^^^^^^^^^^^^^^^^^^^^            #\r\n" +
        "#                                               ^^^^^^^^^^^^^^^^^^^^^^^^            #\r\n" +
        "#    ^^^^^^^^^^^^^^^^^^^^^^^                                   ________________     #\r\n" +
        "#    ^^^^^^^^^^^^^^^^^^^^^^^                                  <_ New map Soon _>    #\r\n" +
        "#    ^^^^^^^^^^^^^^^^^^^^^^^                                         ^|^            #\r\n" +
        "#    ^^^^^^^^^^^^^^^^^^^^^^^                                          |             #\r\n" +
        "#                                                                                   #\r\n" +
        "#####################################################################################\r\n";

        Player = new Player();
        PlacePlayerOnMap(5, 5);
    }

    private void PlacePlayerOnMap(int x, int y)
    {
        // Mettre à jour la position du joueur sur la carte
        Player.X = x;
        Player.Y = y;

        // Mettre à jour la carte avec la position du joueur
        char[] mapArray = myMap.ToCharArray();
        int width = myMap.IndexOf("\r\n") + 2; // Largeur de la carte (en tenant compte des retours à la ligne)
        int index = (y * width) + x;
        mapArray[index] = '*'; // Placez le joueur sur la carte
        myMap = new string(mapArray);
    }

    public void MovePlayer(Direction direction)
    {
        int newX = Player.X;
        int newY = Player.Y;

        switch (direction)
        {
            case Direction.Up:
                newY--;
                break;
            case Direction.Down:
                newY++;
                break;
            case Direction.Left:
                newX--;
                break;
            case Direction.Right:
                newX++;
                break;
        }

        if (IsInBounds(newX, newY) && CanMoveTo(newX, newY))
        {
            Player.X = newX;
            Player.Y = newY;
            CheckForWildPokemon();
        }
    }

    private bool IsInBounds(int x, int y)
    {
        return x >= 0 && x < myMap.IndexOf("\r\n") + 2 && y >= 0 && y < myMap.Split('\n').Length;
    }

    private bool CanMoveTo(int x, int y)
    {
        int index = (y * (myMap.IndexOf("\r\n") + 2)) + x;
        return myMap[index] == ' ' || myMap[index] == '^'; // Vérifiez si la case est vide ou une herbe haute
    }

    private void CheckForWildPokemon()
    {
        if (myMap[Player.Y * (myMap.IndexOf("\r\n") + 2) + Player.X] == '^')
        {
            if (random.Next(2) == 0) // 50% de chance de rencontrer un Pokémon sauvage
            {
                // Déclenchez l'événement de combat Pokémon sauvage
                Console.WriteLine("Un Pokémon sauvage apparaît !");
                //  apel la phase de combat
            }
        }
    }
}

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}
