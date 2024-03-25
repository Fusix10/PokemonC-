using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transphorme
{
    public class Pos
    {
        int x;
        int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
    Pos pos;

    public Pos Pos1 { get => pos; set => pos = value; }

    public Transphorme()
    {
        pos = new Pos();
        pos.X = 0;
        pos.Y = 0;
    }
    

}

