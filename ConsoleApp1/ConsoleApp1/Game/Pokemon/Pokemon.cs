using static IMove;

namespace ConsoleApp1
{
    public class Pokemon : IMove
    {
        public class Pos
        {
            int x, y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }
        List<List<int>> ViewMoveResult;
        List<String> Icone;
        public int _id;
        int _pv;
        int _dmg;
        Pos p;
        List<MoveP> ELMouvement;
        List<List<MoveP>> mouvement;

        internal List<MoveP> ELMouvement1 { get => ELMouvement; set => ELMouvement = value; }
        public List<List<MoveP>> Mouvement { get => mouvement; set => mouvement = value; }
        public Pos P { get => p; set => p = value; }
        public List<List<int>> ViewMoveResult1 { get => ViewMoveResult; set => ViewMoveResult = value; }

        public Pokemon(int Where)
        {
            ViewMoveResult = new List<List<int>>();
            String IconeL1 = "(| |)";
            String IconeL2 = "|o|o|";
            String IconeL3 = "*-b-*";
            String IconeL4 = "|___|";

            p = new Pos();
            _id = Where;
            _pv = 0;
            _dmg = 0;
            p = new Pos();
            mouvement = new List<List<MoveP>>();
            p.X = 2;
            p.Y = 2;

        }
        void IMove.MakeMove(int IsTheMove)
        {
            for (int j = 0; j < mouvement[IsTheMove].Count; j++)
            {
                if (mouvement[IsTheMove][j] == MoveP.Up)
                {
                    p.Y = p.Y + 1;
                }
                else if (mouvement[IsTheMove][j] == MoveP.Down)
                {
                    p.Y = p.Y - 1;
                }
                else if (mouvement[IsTheMove][j] == MoveP.Left)
                {
                    p.X = p.X - 1;
                }
                else if (mouvement[IsTheMove][j] == MoveP.Right)
                {
                    p.X = p.X + 1;
                }
            }
        }
        public void ViewMove(Window window)
        {
            for (int i = 0; i < mouvement.Count; i++)
            {
                int u = p.X;
                int f = p.Y;
                for (int j = 0; j < mouvement[i].Count; j++)
                {
                    if (mouvement[i][j] == MoveP.Up)
                    {
                        f++;
                    }
                    else if (mouvement[i][j] == MoveP.Down)
                    {
                        --f;
                    }
                    else if (mouvement[i][j] == MoveP.Left)
                    {
                        --u;
                    }
                    else if (mouvement[i][j] == MoveP.Right)
                    {
                        u++;
                    }
                }
                if (f <= window.Windowfigth1.Count()-1 && f >=0 && u <= window.Windowfigth1[0].Count()-1 && u >= 0)
                {
                    Console.SetCursorPosition((u + 1) * window.Windowfigth1[u][f].H - 4, (f + 1) * window.Windowfigth1[u][f].W - 3);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("MMM");
                    Console.ForegroundColor = ConsoleColor.White;
                    List<int> l = new List<int>();
                    l.Add(u);l.Add(f);
                    ViewMoveResult.Add(l);
                }
            }
        }
        public void DrawPokemon(Window window)
        {
            Console.SetCursorPosition((p.X+1)*window.Windowfigth1[p.X][p.Y].H -5,( p.Y + 1 )* window.Windowfigth1[p.X][p.Y].W -5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Icone);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


