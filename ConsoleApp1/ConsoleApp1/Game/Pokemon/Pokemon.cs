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

        String Icone;
        public int _id;
        int _pv;
        int _dmg;
        Pos p;
        List<List<MoveP>> mouvement;


        public Pokemon(int Where)
        {
            Icone = "p";
            p = new Pos();
            _id = Where;
            _pv = 0;
            _dmg = 0;
            p = new Pos();
            mouvement = new List<List<MoveP>>();
            p.X = 4;
            p.Y = 4;

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
        public void DrawPokemon(Window window)
        {

            Console.SetCursorPosition((p.X+1)*window.Windowfigth1[p.X][p.Y].H -3,( p.Y + 1 )* window.Windowfigth1[p.X][p.Y].W -3);
            Console.Write(Icone);
        }
    }
}


