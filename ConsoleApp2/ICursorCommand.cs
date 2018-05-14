using System;

namespace LifeGame
{
    interface ICursorCommand
    {
        void PerformCommand(ConsoleKey commandCharacter);
    }
}