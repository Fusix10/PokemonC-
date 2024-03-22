using static IMove;

public class Player: IMove
{
    private struct Pos
    {
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
    Pos p;
    List<MoveP> list;
    public Player()
    {
        p = new Pos();
        list = new List<MoveP>();
        list.Add(MoveP.Up);
        list.Add(MoveP.Down);
        list.Add(MoveP.Left);
        list.Add(MoveP.Right);
    }
    void IMove.MakeMove(int IsTheMove)
    {
        if (list[IsTheMove] == MoveP.Up)
        {
            p.Y = p.Y + 1;
        }
        else if (list[IsTheMove] == MoveP.Down)
        {
            p.Y = p.Y - 1;
        }
        else if (list[IsTheMove] == MoveP.Left)
        {
            p.X = p.X - 1;
        }
        else if (list[IsTheMove] == MoveP.Right)
        {
            p.X = p.X + 1;
        }
    }
    
}
