using ConsoleApp1;
using System.Drawing;

public class Window
{
    public enum Color { WHITE, BLACK }

    public class Case
    {
        Pokemon pok;
        int x;
        int y;
        int w;
        int h;
        Color color;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int W { get => w; set => w = value; }
        public int H { get => h; set => h = value; }
        public Color Color { get => color; set => color = value; }
    }
    Case UneCase;
    List<Case> Cases;
    List<List<Case>> Windowfigth;
    public Case UneCase2 { get => UneCase; set => UneCase = value; }
    public List<Case> Cases1 { get => Cases; set => Cases = value; }
    public List<List<Case>> Windowfigth1 { get => Windowfigth; set => Windowfigth = value; }

    public Window(int x, int y)
    {
        Windowfigth = new List<List<Case>>();

        for (int i = 0; i < x; i++)
        {
            Cases = new List<Case>();
            for (int j = 0; j < y; j++)
            {
                UneCase = new Case();
                UneCase.W = 5;
                UneCase.H = 5;
                UneCase.Color = Color.WHITE;

                UneCase.X = i;
                UneCase.Y = j;
                if (i % 2 == 0)
                {
                    if (j % 2 == 0)
                    {
                        UneCase.Color = Color.BLACK;

                    }
                    else
                    {
                        UneCase.Color = Color.WHITE;
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        UneCase.Color = Color.WHITE;

                    }
                    else
                    {
                        UneCase.Color = Color.BLACK;
                    }
                }
                Cases.Add(UneCase);

            }
            Windowfigth.Add(Cases);
        }
    }
    public void DrawWindow()
    {
        for (int i = 0; i < Windowfigth.Count; i++)
        {
            for (int j = 0; j < Windowfigth.Count; j++)
            {
                Console.SetCursorPosition(j * 5, i * 5);
                if (Windowfigth[i][j].Color == Color.WHITE)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.SetCursorPosition(j * 5, i * 5 + k);
                        Console.Write("/////");
                    }
                    //chars = "/////\n/////\n/////\n/////\n/////\n";
                }
                else
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.SetCursorPosition(j * 5, i * 5 + k);
                        Console.Write("OOOOO");
                    }
                    //chars = "OOOOO\nOOOOO\nOOOOO\nOOOOO\nOOOOO\n";
                }

            }
        }
    }
}
