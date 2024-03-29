using System;
using ConsoleApp1;

internal class Map
{
    public class CharactereDesc
    {
        public char Character;
        public System.ConsoleColor Color;
        public bool CanPassThrough;
        public Action? Event;
    }

    public List<CharactereDesc> Characts { get; set; }
    public CharactereDesc[][] Maps;
    public string myMap;
    public Player Player { get; set; }

    public Map()
    {
        Maps = new CharactereDesc[87][];

        Characts = new List<CharactereDesc>();

        myMap =
        "#####################################################################################\r\n" +
        "#                                                                                   #\r\n" +
        "#                                                                                   #\r\n" +
        "#                                                                                   #\r\n" +
        "#                                                                                   #\r\n" +
        "#                                                                                   #\r\n" +
        "#                                               ########################            #\r\n" +
        "#                                               ########################            #\r\n" +
        "#                                               ########################            #\r\n" +
        "#                                               ########################            #\r\n" +
        "#                                               ########################            #\r\n" +
        "#                                               ########################            #\r\n" +
        "#                                               ########################            #\r\n" +
        "#    #######################                                                        #\r\n" +
        "#    #######################                      &                                 #\r\n" +
        "#    #######################                                                        #\r\n" +
        "#    #######################                                                        #\r\n" +
        "#                                                                                   #\r\n" +
        "#####################################################################################\r\n";

        for (int i = 0; i < Maps.Length; i++)
        {
            Maps[i] = new CharactereDesc[19];
            for (int j = 0; j < Maps[i].Length; j++)
            {
                Maps[i][j] = ReadCharacter(i, j);
            }
        }
        //' ','#','&',

        Console.Clear();
        for (int i = 0; i < Maps.Length; i++)
        {
            for (int j = 0; j < Maps[i].Length; j++)
            {
                DrawChar(i, j);
            }
        }


        Player = new Player();
        Player.X = 5;
        Player.Y = 5;



        Console.SetCursorPosition(Player.X, Player.Y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('C');
    }

    private void DrawChar(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.BackgroundColor = Maps[x][y].Color;
        Console.ForegroundColor = Maps[x][y].Color;
        Console.Write(Maps[x][y].Character);
    }

    public void MoveCharacter(int x, int y)
    {
        if (!CanMoveTo(x, y)) return;

        if (Maps[x][y].Event != null) Maps[x][y].Event?.Invoke();

        DrawChar(Player.X, Player.Y);

        Player.X = x;
        Player.Y = y;

        Console.SetCursorPosition(Player.X, Player.Y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('C');
    }

    private CharactereDesc ReadCharacter(int x, int y)
    {
        char c;
        c = myMap[y * Maps.Length + x];
        CharactereDesc desc = new CharactereDesc();
        desc.Character = c;
        switch (c)
        {
            case ' ':
                desc.CanPassThrough = true;
                desc.Color = ConsoleColor.Black;
                break;
            case '#':
                desc.CanPassThrough = false;
                desc.Color = ConsoleColor.Green;
                break;
            case '&':
                desc.CanPassThrough = true;
                desc.Color = ConsoleColor.White;
                desc.Event = () =>
                {
                    Engine.instance?.LaunchBattle();
                };
                break;
            default:
                desc.CanPassThrough = false;
                desc.Color = ConsoleColor.Magenta;
                break;

        }

        return desc;
    }

    private bool CanMoveTo(int x, int y)
    {
        return Maps.Length > x && Maps[x].Length > y && Maps[x][y].CanPassThrough;
    }


    public void Update()
    {
        switch (InputManager.instance?.Ivalue)
        {
            case 1:
                MoveCharacter(Player.X, Player.Y - 1);
                break;
            case 2:
                MoveCharacter(Player.X, Player.Y + 1);
                break;
            case 3:
                MoveCharacter(Player.X - 1, Player.Y);
                break;
            case 4:
                MoveCharacter(Player.X + 1, Player.Y);
                break;
        }
    }
}