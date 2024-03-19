using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class InputManager
{
    void Update()
    {
        if (Console.ReadKey(ConsoleKey.UpArrow))
        {
            Console.WriteLine("up arrow key is held down");
        }

        if (Console.ReadKey('a'))
        {
           Console.WriteLine("down arrow key is held down");
        }
    }
}