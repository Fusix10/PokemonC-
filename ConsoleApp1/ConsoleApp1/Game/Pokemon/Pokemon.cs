using static IMove;

namespace ConsoleApp1
{
    public class Pokemon : IMove
    {
        private struct Pos
        {
            int x, y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }

        List<Char> Icone;
        public int _id;
        int _pv;
        int _dmg;
        Pos p;
        List<List<MoveP>> mouvement;


        public Pokemon(int Where)
        {
            _id = Where;
            _pv = 0;
            _dmg = 0;
            p = new Pos();

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
    }
}


