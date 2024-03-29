﻿using ConsoleApp1;
using System.Numerics;
using System.Xml.Linq;

public class Engine
{
    InputManager inputManager = new InputManager();
    Ratio ratio;
    Window aled;
    Player player;
    bool PreMove = false;
    bool ingame = true;
    public Engine()
    {
        player = new Player();
        CreationPlayer();
        Console.Clear();
        aled = new Window(5, 5);
        aled.DrawWindow();
        ratio = new Ratio(0);
        player.Inventory.AddPokemon(ratio);
        aled = new Window(5, 5);
        inputManager.Awake();
        aled.DrawWindow();
        ratio.DrawPokemon(aled);
        
    }
    public void Update()
    {
        
        while (ingame)
        {
            inputManager.Update();

            InputFolder();
            

            if (PreMove == true)
            {
                ratio.ViewMove(aled);
            }
        }
    }
    void InputFolder()
    {
        if (inputManager.Ivalue == 10)
        {
            ingame = false;

        }
        else if (inputManager.Ivalue == 1)
        {
            if (aled.Elcursor1.Y > 0)
            {
                --aled.Elcursor1.Y;
                aled.DrawWindow();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 2)
        {
            if (aled.Elcursor1.Y < 4)
            {
                ++aled.Elcursor1.Y;
                aled.DrawWindow();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 3)
        {
            if (aled.Elcursor1.X > 0)
            {
                --aled.Elcursor1.X;
                aled.DrawWindow();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 4)
        {
            if (aled.Elcursor1.X < 4)
            {
                ++aled.Elcursor1.X;
                aled.DrawWindow();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 5 && aled.Elcursor1.X == ratio.P.X && aled.Elcursor1.Y == ratio.P.Y && PreMove == false)
        {
            PreMove = true;
            ratio.ViewMove(aled);
        }
        else if (inputManager.Ivalue == 5 && aled.Elcursor1.X == ratio.P.X && aled.Elcursor1.Y == ratio.P.Y && PreMove == true)
        {
            PreMove = false;
            aled.DrawWindow();
            ratio.DrawPokemon(aled);
        }
        else if (inputManager.Ivalue == 5 && PreMove == true)
        {
            for (int i = 0; i < ratio.ViewMoveResult1.Count(); i++)
            {

                if (aled.Elcursor1.X == ratio.ViewMoveResult1[i][0] && aled.Elcursor1.Y == ratio.ViewMoveResult1[i][1])
                {

                    ratio.P.X = ratio.ViewMoveResult1[i][0];


                    ratio.P.Y = ratio.ViewMoveResult1[i][1];

                    aled.DrawWindow();
                    ratio.DrawPokemon(aled);
                }


            }
        }
    }

    void CreationPlayer() 
    {
        Console.WriteLine("Bonjours ! voici dans une version bêta de PokeChess\nveuilleur choisir un nom et une age pour votre perso:\n");
        String ?Recup = Console.ReadLine();
        Console.WriteLine("\n");
        while (Recup == null)
        {
            Console.WriteLine("je ne sais pas qu'esque ta écrit mais RATIO + CHEH\n");
            Console.WriteLine("bon allez ton name ?:\n");
            Recup = Console.ReadLine();
            Console.WriteLine("\n");
        }
        player.Name1 = Recup;
        Console.WriteLine($"très bien {Recup}, ton age stp ?:\n");
        Recup = null;
        Recup = Console.ReadLine();
        Console.WriteLine("\n");
        while (Recup == null) 
        {
            Console.WriteLine("je ne sais pas qu'esque ta écrit mais RATIO + CHEH\n");
            Console.WriteLine("bon allez ton Age ?:\n");
            Recup = Console.ReadLine();
            Console.WriteLine("\n");
        }
        player.Age1 = Recup;
    }
}
