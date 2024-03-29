using ConsoleApp1;
using System.ComponentModel;
using System.Numerics;
using System.Xml.Linq;

public class Engine
{
    public static Engine? instance;
    
    InputManager inputManager = new InputManager();
    RoundManager roundManager;
    Window Window;
    Player player;
    bool PreMove = false;
    bool ingame = true;
    
    public Engine()
    {
        instance = this;
        Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
        player = new Player();
        CreationPlayer();
        Console.Clear();
        Window = new Window(10, 9);
        Window.DrawWindowFigth();
        player.Inventory.AddPokemonInvActuel(new Pikachute(0, 0, 0));
        player.Inventory.AddPokemonInvActuel(new Pikachute(1, 1, 1));
        inputManager.Awake();
        Window.DrawWindowFigth();
        roundManager = new RoundManager();
    }

    public bool Ingame {set => ingame = value; }
    public Window Window1 { get => Window; }
    public InputManager InputManager { get => inputManager;}
    public Player Player { get => player; set => player = value; }

    public void Update()
    {
        
        while (ingame)
        {
            inputManager.Update();
            roundManager.Update();

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
        while (Recup[0] == null || Recup == "" || Recup == " ")
        {
            Console.WriteLine("je ne sais pas qu'esque ta écrit mais RATIO + CHEH\n");
            Console.WriteLine("bon allez ton Age ?:\n");
            Recup = Console.ReadLine();
            Console.WriteLine("\n");
        }
        player.Age1 = Recup;
    }
}
