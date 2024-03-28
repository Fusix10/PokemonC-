using ConsoleApp1;
using System.ComponentModel;
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
        Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
        player = new Player();
        CreationPlayer();
        Console.Clear();
        aled = new Window(9, 10);
        aled.DrawWindowFigth();
        ratio = new Ratio(0, 3, 0);
        player.Inventory.AddPokemon(ratio);
        inputManager.Awake();
        aled.DrawWindowFigth();
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
                ratio.ViewMove(aled,ratio.Mouvement,0);
                ratio.ViewMove(aled, ratio.RangeAttack, 1);
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
                aled.DrawWindowFigth();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 2)
        {
            if (aled.Elcursor1.Y < aled.Windowfigth1.Count() - 1)
            {
                ++aled.Elcursor1.Y;
                aled.DrawWindowFigth();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 3)
        {
            if (aled.Elcursor1.X > 0)
            {
                --aled.Elcursor1.X;
                aled.DrawWindowFigth();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 4)
        {
            if (aled.Elcursor1.X < aled.Windowfigth1[0].Count() - 1)
            {
                ++aled.Elcursor1.X;
                aled.DrawWindowFigth();
                ratio.DrawPokemon(aled);

            }
        }
        else if (inputManager.Ivalue == 5 && aled.Elcursor1.X == ratio.P.X && aled.Elcursor1.Y == ratio.P.Y && PreMove == false)
        {
            PreMove = true;
            ratio.ViewMove(aled, ratio.Mouvement, 0);
            ratio.ViewMove(aled, ratio.RangeAttack, 1);
        }
        else if (inputManager.Ivalue == 5 && aled.Elcursor1.X == ratio.P.X && aled.Elcursor1.Y == ratio.P.Y && PreMove == true)
        {
            PreMove = false;
            aled.DrawWindowFigth();
            ratio.DrawPokemon(aled);
        }
        else if (inputManager.Ivalue == 5 && PreMove == true)
        {
            for (int i = 0; i < ratio.ViewMoveResult1.Count(); i++)
            {

                if (aled.Elcursor1.X == ratio.ViewMoveResult1[i][0] && aled.Elcursor1.Y == ratio.ViewMoveResult1[i][1])
                {
                    aled.Windowfigth1[ratio.P.X][ratio.P.Y].Pok = null;
                    ratio.P.X = ratio.ViewMoveResult1[i][0];
                    ratio.P.Y = ratio.ViewMoveResult1[i][1];
                    aled.Windowfigth1[ratio.P.Y][ratio.P.X].Pok = ratio;
                    aled.DrawWindowFigth();
                    ratio.DrawPokemon(aled);
                    PreMove = false;
                    ratio.ViewMoveResult1.Clear();
                    ratio.ViewAttackResult.Clear();
                    break;
                }

            }
            for (int i = 0; i < ratio.ViewAttackResult.Count(); i++)
            {
                if (aled.Elcursor1.X == ratio.ViewAttackResult[i][0] && aled.Elcursor1.Y == ratio.ViewAttackResult[i][1])
                {
                    if (aled.Windowfigth1[aled.Elcursor1.X][aled.Elcursor1.Y].Pok != null)
                    {
                        aled.Windowfigth1[aled.Elcursor1.X][aled.Elcursor1.Y].Pok.TakeDommage(ratio.Dmg);
                        PreMove = false;
                        Console.WriteLine("dans ta geule");
                        ratio.ViewMoveResult1.Clear();
                        break;
                    }
                }
            }
        }
    }

    void CreationPlayer() 
    {
        Console.WriteLine("Bonjours ! voici dans une version bêta de PokeChess\nveuilleur choisir un nom et une age pour votre perso:\n");
        String ?Recup = Console.ReadLine();
        Console.WriteLine("\n");
        while (Recup == null || Recup == "" || Recup == " ")
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
        while (Recup == null || Recup == "" || Recup == " ")
        {
            Console.WriteLine("je ne sais pas qu'esque ta écrit mais RATIO + CHEH\n");
            Console.WriteLine("bon allez ton Age ?:\n");
            Recup = Console.ReadLine();
            Console.WriteLine("\n");
        }
        player.Age1 = Recup;
    }
}
