using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMove
{
    public enum MoveP
    {
        Up,
        Down,
        Left,
        Right
    }
    void MakeMove(int IsTheMove);

}
 
