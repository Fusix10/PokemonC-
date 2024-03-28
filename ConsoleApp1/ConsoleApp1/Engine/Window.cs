using ConsoleApp1;
using System.Drawing;

public class Window
{
    public enum Color { WHITE, BLACK }

    public class Case
    {
        int id = 0;
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
        public int Id { get => id; set => id = value; }
        public Pokemon Pok { get => pok; set => pok = value; }
    }
    public class Cursor
    {
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
    Case UneCase;
    List<Case> Cases;
    List<List<Case>> Windowfigth;
    Cursor Elcursor;
    public Case UneCase2 { get => UneCase; set => UneCase = value; }
    public List<Case> Cases1 { get => Cases; set => Cases = value; }
    public List<List<Case>> Windowfigth1 { get => Windowfigth; set => Windowfigth = value; }
    public Cursor Elcursor1 { get => Elcursor; set => Elcursor = value; }

    public Window(int x, int y)
    {
        Elcursor = new Cursor();
        Elcursor.X = 5; Elcursor.Y = 0;
        Windowfigth = new List<List<Case>>();

        for (int i = 0; i < x; i++)
        {
            Cases = new List<Case>();
            for (int j = 0; j < y; j++)
            {
                UneCase = new Case();
                UneCase.W = 9;
                UneCase.H = 5;
                UneCase.Color = Color.WHITE;
                UneCase.Pok = null;

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
            int test = Windowfigth.Count();
        }
    }
    public void DrawWindowFigth()
    {
        for (int i = 0; i < Windowfigth.Count; i++)
        {
            for (int j = 0; j < Windowfigth[i].Count; j++)
            {
                Console.SetCursorPosition(j * Windowfigth[i][j].W, i * Windowfigth[i][j].H);
                if (Windowfigth[i][j].Color == Color.WHITE)
                {
                    for (int IncrementeH = 0; IncrementeH < Windowfigth[i][j].H; IncrementeH++)
                    {
                        if (i == Elcursor.Y && j == Elcursor.X)
                        {
                            if (IncrementeH == 0 || IncrementeH == Windowfigth[0][0].H - 1)
                            {
                                Console.SetCursorPosition(j * Windowfigth[i][j].W, i * Windowfigth[i][j].H + IncrementeH);
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                for(int IncrementeW = 0; IncrementeW < Windowfigth[0][0].W; IncrementeW++)
                                {
                                    if (IncrementeW == 0)
                                    {
                                        Console.Write("[");
                                    }
                                    else if (IncrementeW == Windowfigth[0][0].W - 1)
                                    {
                                        Console.Write("]");
                                    }
                                    else
                                    {
                                        Console.Write("-");
                                    }
                                }
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(j * Windowfigth[i][j].W, i * Windowfigth[i][j].H + IncrementeH);
                            Console.BackgroundColor = ConsoleColor.White;
                            for (int IncrementeW = 0; IncrementeW < Windowfigth[0][0].W; IncrementeW++)
                            {
                                Console.Write(" ");
                                
                            }
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        
                    }
                }
                else
                {
                    for (int IncrementeH = 0; IncrementeH < Windowfigth[i][j].H; IncrementeH++)
                    {
                        if (i == Elcursor.Y && j == Elcursor.X)
                        {
                            if (IncrementeH == 0 || IncrementeH == Windowfigth[0][0].H - 1)
                            {
                                Console.SetCursorPosition(j * Windowfigth[i][j].W, i * Windowfigth[i][j].H + IncrementeH);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                for (int IncrementeW = 0; IncrementeW < Windowfigth[0][0].W; IncrementeW++)
                                {
                                    if (IncrementeW == 0)
                                    {
                                        Console.Write("[");
                                    }
                                    else if (IncrementeW == Windowfigth[0][0].W - 1)
                                    {
                                        Console.Write("]");
                                    }
                                    else
                                    {
                                        Console.Write("-");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(j * Windowfigth[i][j].W, i * Windowfigth[i][j].H + IncrementeH);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            for (int IncrementeW = 0; IncrementeW < Windowfigth[0][0].W; IncrementeW++)
                            {
                                Console.Write(" ");
                            }
                        }

                    }
                }

            }
        }
    }
}
