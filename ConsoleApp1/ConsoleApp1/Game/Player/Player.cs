using static IMove;

public class Player: IMove 
{
    string Name;
    string Age;
    Transphorme Position;
    Inventory inventory;
    List<MoveP> list;
    public Player()
    {
        Position = new Transphorme();
        inventory = new Inventory();
        list = new List<MoveP>();
        list.Add(MoveP.Up);
        list.Add(MoveP.Down);
        list.Add(MoveP.Left);
        list.Add(MoveP.Right);
    }

    public string Name1 { get => Name; set => Name = value; }
    public string Age1 { get => Age; set => Age = value; }

    void IMove.MakeMove(int IsTheMove)
    {
        
    }
    
}