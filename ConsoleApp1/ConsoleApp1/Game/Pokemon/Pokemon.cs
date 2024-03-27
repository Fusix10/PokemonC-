using static IMove;

namespace ConsoleApp1
{
    public abstract class Pokemon : IMove
    {
        public class Pos
        {
            int x, y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }
        protected List<List<int>> ViewMoveResult;
        private List<List<int>> viewAttackResult;
        protected String Icone;
        private int id;
        protected int _pv;
        protected int _dmg;
        protected Pos p;
        protected List<MoveP> ELMouvement;
        protected List<List<MoveP>> mouvement;
        protected List<MoveP> ElRangeAttack;
        private List<List<MoveP>> rangeAttack;
        protected List<MoveP> ELMouvement1 { get => ELMouvement; set => ELMouvement = value; }
        public List<List<MoveP>> Mouvement { get => mouvement; set => mouvement = value; }
        public Pos P { get => p; set => p = value; }
        public List<List<int>> ViewMoveResult1 { get => ViewMoveResult; set => ViewMoveResult = value; }
        public List<List<int>> ViewAttackResult { get => viewAttackResult; set => viewAttackResult = value; }
        public List<List<MoveP>> RangeAttack { get => rangeAttack;}
        public int Id { get => id;}
        public int Dmg { get => _dmg; }

        public Pokemon(int Where, int x, int y)
        {
            ViewMoveResult = new List<List<int>>();
            ViewAttackResult = new List<List<int>>();
            p = new Pos();
            id = Where;
            _pv = 0;
            _dmg = 0;
            p = new Pos();
            mouvement = new List<List<MoveP>>();
            rangeAttack = new List<List<MoveP>>();
            p.X = x;
            p.Y = y;

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
        public void ViewMove(Window window, List<List<MoveP>> PreViewThis, int Who)
        {

            for (int i = 0; i < PreViewThis.Count; i++)
            {
                int u = p.X;
                int f = p.Y;
                for (int j = 0; j < PreViewThis[i].Count; j++)
                {
                    if (PreViewThis[i][j] == MoveP.Up)
                    {
                        f++;
                    }
                    else if (PreViewThis[i][j] == MoveP.Down)
                    {
                        --f;
                    }
                    else if (PreViewThis[i][j] == MoveP.Left)
                    {
                        --u;
                    }
                    else if (PreViewThis[i][j] == MoveP.Right)
                    {
                        u++;
                    }
                }
                if (f <= window.Windowfigth1.Count()-1 && f >=0 && u <= window.Windowfigth1[0].Count()-1 && u >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if(Who == 0) 
                    {
                        Draw.DrawInCase(window.Windowfigth1[u][f], "MMM", window.Windowfigth1[u][f].W / 2 - 1, window.Windowfigth1[u][f].H / 2);
                    }
                    else
                    {
                        Draw.DrawInCase(window.Windowfigth1[u][f], "XXX", window.Windowfigth1[u][f].W / 2 - 1, window.Windowfigth1[u][f].H / 2);
                    }
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    List<int> l = new List<int>();
                    l.Add(u);l.Add(f);
                    if (Who == 0)
                    {
                        ViewMoveResult.Add(l);
                    }
                    else
                    {
                        ViewAttackResult.Add(l);
                    }
                }
            }
        }
        public void DrawPokemon(Window window)
        {
            Console.SetCursorPosition((p.X+1)*window.Windowfigth1[p.X][p.Y].H -5,( p.Y + 1 )* window.Windowfigth1[p.X][p.Y].W -5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Draw.DrawInCase(window.Windowfigth1[p.X][p.Y], Icone);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public abstract void Attacks();

        public void TakeDommage(int Dommage)
        {
            _pv = _pv - Dommage;
        }
    }
}