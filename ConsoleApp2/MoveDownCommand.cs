using System;

namespace LifeGame
{
    internal class MoveDownCommand : ICursorCommand
    {
        private Cursor pointerToCursor;

        public MoveDownCommand(Cursor inputedCurosr)
        {
            pointerToCursor = inputedCurosr;
        }

        public void PerformCommand(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.DownArrow)
            {
                pointerToCursor.YPosition = pointerToCursor.YPosition + 1;
            }
        }
    }
}