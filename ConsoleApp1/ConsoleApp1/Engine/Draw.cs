using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

public static class Draw
{
    public static void DrawInCase(Window.Case Voila,String WriteThis)
    {
        List<string> lines = new List<string>();
        Console.SetCursorPosition(Voila.X*5, Voila.Y*5);
        for (int i = 0; i < WriteThis.Length; i++) 
        {
            if (WriteThis[i] == '=')
            {
                if (WriteThis[i+1] == '/')
                {
                    if (WriteThis[i + 2] == '=')
                    {
                        for(int j = 0;  j < i; j++) 
                        {
                            String ?t;
                            ?t[j] = WriteThis[j];
                        }
                    }
                }
            }

        }
    }
}

