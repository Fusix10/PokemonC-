using ConsoleApp1;

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
        Elcursor.X = 0; Elcursor.Y = 0;
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
                if (Windowfigth[i][j].Color == Color.WHITE)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (i == Elcursor.X && j == Elcursor.Y)
                    {
                        for(int IncrementH = 0; IncrementH < Windowfigth[i][j].H; IncrementH++)
                        {
                            Console.SetCursorPosition(i * Windowfigth[i][j].W, j * Windowfigth[i][j].H + IncrementH);
                            if (IncrementH == 0 || IncrementH == Windowfigth[i][j].H - 1)
                            {
                                for (int IncrementW = 0; IncrementW < Windowfigth[i][j].W; IncrementW++)
                                {
                                    if(IncrementW == 0)
                                    {
                                        Console.Write("[");
                                    }
                                    else if(IncrementW == Windowfigth[i][j].W-1)
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
                    }
                    else
                    {
                        for (int IncrementH = 0; IncrementH < Windowfigth[i][j].H; IncrementH++)
                        {
                            Console.SetCursorPosition(i * Windowfigth[i][j].W, j * Windowfigth[i][j].H + IncrementH);
                            for (int IncrementW = 0; IncrementW < Windowfigth[i][j].W; IncrementW++)
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (i == Elcursor.X && j == Elcursor.Y)
                    {
                        for (int IncrementH = 0; IncrementH < Windowfigth[i][j].H; IncrementH++)
                        {
                            Console.SetCursorPosition(i * Windowfigth[i][j].W, j * Windowfigth[i][j].H + IncrementH);
                            if (IncrementH == 0 || IncrementH == Windowfigth[i][j].H - 1)
                            {
                                for (int IncrementW = 0; IncrementW < Windowfigth[i][j].W; IncrementW++)
                                {
                                    if (IncrementW == 0)
                                    {
                                        Console.Write("[");
                                    }
                                    else if (IncrementW == Windowfigth[i][j].W - 1)
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
                    }
                    else
                    {
                        for (int IncrementH = 0; IncrementH < Windowfigth[i][j].H; IncrementH++)
                        {
                            Console.SetCursorPosition(i * Windowfigth[i][j].W, j * Windowfigth[i][j].H + IncrementH);
                            for (int IncrementW = 0; IncrementW < Windowfigth[i][j].W; IncrementW++)
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
