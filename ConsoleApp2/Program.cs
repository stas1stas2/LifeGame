using System;

namespace LifeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Universe.PrintAbleUniverse a = new Universe.PrintAbleUniverse(10, 10);
            a.ChangeCell(0,2);
            a.MoveCursorLeft();
            a.MoveCursorRight();
            a.PrintField();
        }
    }
}
