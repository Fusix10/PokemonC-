using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using static System.Net.Mime.MediaTypeNames;

public static class Draw
{
    public static void DrawInCase(Window.Case Voila, String WriteThis, int StartY = 0, int StartX = 0)
    {
        String[] lines = WriteThis.Split(new string[] { "=/=" }, StringSplitOptions.None); ;
        Console.SetCursorPosition(Voila.X*Voila.W + StartX, Voila.Y* Voila.H + StartY);
        for (int i = 0; i < lines.Length; i++)
        {
            Console.Write(lines[i]);
            Console.SetCursorPosition(Voila.X * Voila.W + StartX, Voila.Y * (Voila.H + StartY) + i);
        }
    }
}

