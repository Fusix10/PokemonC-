using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using static IMove;

namespace ConsoleApp1
{
    public class Pokemon : IMove
    {
        public class Pos
        {
            int x, y;
            bool View;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
            public bool View1 { get => View; set => View = value; }
        } 
        protected List<Vector2> ViewMoveResult;
        private List<Vector2> viewAttackResult;
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
        public List<Vector2> ViewMoveResult1 { get => ViewMoveResult; set => ViewMoveResult = value; }
        public List<Vector2> ViewAttackResult { get => viewAttackResult; set => viewAttackResult = value; }

        public List<List<MoveP>> RangeAttack { get => rangeAttack;}
        public int Id { get => id;}
        public int Dmg { get => _dmg; }

        public Pokemon(int Where, int x, int y)
        {
            
            ViewMoveResult = new List<Vector2>();
            ViewAttackResult = new List<Vector2>();
            p = new Pos();
            id = Where;
            _pv = 0;
            _dmg = 0;
            p = new Pos();
            mouvement = new List<List<MoveP>>();
            rangeAttack = new List<List<MoveP>>();
            p.X = x;
            p.Y = y;
            p.View1 = false;

        }
        void IMove.MakeMove(int IsTheMove)
        {
            for (int j = 0; j < mouvement[IsTheMove].Count; j++)
            {
                if (mouvement[IsTheMove][j] == MoveP.Up)
                {
                    p.X = p.X + 1;
                }
                else if (mouvement[IsTheMove][j] == MoveP.Down)
                {
                    p.X = p.X - 1;
                }
                else if (mouvement[IsTheMove][j] == MoveP.Left)
                {
                    p.Y = p.Y - 1;
                }
                else if (mouvement[IsTheMove][j] == MoveP.Right)
                {
                    p.Y = p.Y + 1;
                }
            }
        }
        public void ViewMove(Window window, List<List<MoveP>> PreViewThis, int Who)
        {

            for (int i = 0; i < PreViewThis.Count; i++)
            {
                int x = p.X;
                int y = p.Y;
                for (int j = 0; j < PreViewThis[i].Count; j++)
                {
                    if (PreViewThis[i][j] == MoveP.Up)
                    {
                        x++;
                    }
                    else if (PreViewThis[i][j] == MoveP.Down)
                    {
                        --x;
                    }
                    else if (PreViewThis[i][j] == MoveP.Left)
                    {
                        --y;
                    }
                    else if (PreViewThis[i][j] == MoveP.Right)
                    {
                        y++;
                    }
                }



                if (x < window.Windowfigth1.Count() && x >= 0 && y < window.Windowfigth1[0].Count() && y >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if(Who == 0) 
                    {
                        if (x < window.Windowfigth1.Count() && x >= 0 && y < window.Windowfigth1[0].Count() && y >= 0)
                        {
                            Draw.DrawInCase(window.Windowfigth1[x][y], "MMM", window.Windowfigth1[x][y].W / 2 - 1, window.Windowfigth1[x][y].H / 2);
                        }
                        
                    }
                    else
                    {
                        if (x < window.Windowfigth1.Count() && x >= 0 && y < window.Windowfigth1[0].Count() && y >= 0)
                        {
                            Draw.DrawInCase(window.Windowfigth1[x][y], "XXX", window.Windowfigth1[x][y].W / 2 - 1, window.Windowfigth1[x][y].H / 2);
                        }
                    }
                    
                    Console.ForegroundColor = ConsoleColor.White;

                    if (Who == 0) ViewMoveResult.Add(new(x, y));
                    else ViewAttackResult.Add(new(x, y));

                }
            }
        }
        public void DrawPokemon(Window window)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Draw.DrawInCase(window.Windowfigth1[p.X][p.Y], Icone);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual void Attacks()
        {

        }

        public void TakeDommage(int Dommage)
        {
            _pv = _pv - Dommage;
        }
    }
}