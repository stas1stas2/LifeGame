using System;

namespace LifeGame
{
    internal interface ICursorCommand
    {
        void PerformCommand(ConsoleKey commandCharacter);
    }
}