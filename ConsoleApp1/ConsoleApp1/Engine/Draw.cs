using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using static System.Net.Mime.MediaTypeNames;

public static class Draw
{
    public static void DrawInCase(Window.Case Voila,String WriteThis)
    {
        String[] lines = WriteThis.Split(new string[] { "=/=" }, StringSplitOptions.None); ;
        Console.SetCursorPosition(Voila.X*5, Voila.Y*5);
        for (int i = 0; i < lines.Length; i++)
        {
            Console.Write(lines[i]);
            Console.SetCursorPosition(Voila.X * 5, Voila.Y * 5+i);
        }
    }
}

