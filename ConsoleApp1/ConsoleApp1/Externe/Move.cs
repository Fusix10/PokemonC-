using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal interface IMove
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

