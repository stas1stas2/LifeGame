using System;

namespace LifeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Universe.ChangeableUniverse a = new Universe.ChangeableUniverse(10, 10);
            a.ChangeCell(0,9);
            a.PrintField();
        }
    }
}
