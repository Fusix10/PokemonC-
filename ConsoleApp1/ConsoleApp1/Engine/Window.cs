using ConsoleApp1;
public class Window
{
    
    private struct Case
    {
        Pokemon pok;
        int x;
        int y;
        int w;
        int h;
        bool color;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int W { get => w; set => w = value; }
        public int H { get => h; set => h = value; }
        public bool Color { get => color; set => color = value; }
    }
    Case UneCase;
    List<Case> Cases;
    List<List<Case>> Windowfigth;
    public Window(int x, int y)
    {
        Cases = new List<Case>();
        Windowfigth = new List<List<Case>>();

        UneCase.W = 5;
        UneCase.H = 5;
        UneCase.Color = false;//false == blanc true == noir
        for (int i = 0; i < x; i++) 
        {
            for (int j = 0; j < y; j++)
            {
                UneCase.X = i;
                UneCase.Y = j;
                if (UneCase.Color == false)
                {
                    UneCase.Color = true;
                }
                else
                {
                    UneCase.Color = false;
                }
                Cases.Add(UneCase);
            }
            Windowfigth.Add(Cases);
        }
    }
    public void DrawWindow()
    {
        string chars;
        for (int i = 0;i < Windowfigth.Count; i++)
        {
            for(int j = 0;j < Windowfigth[i].Count; j++)
            {
                if(Windowfigth[i][j].Color == false) 
                {
                    chars = "/////\n/////\n/////\n/////\n/////";
                }
                else
                {
                    chars = "OOOOO\nOOOOO\nOOOOO\nOOOOO\nOOOOO";
                }
                Console.Write(chars);
                Console.Write("\n");
            }
        }
    }
}
