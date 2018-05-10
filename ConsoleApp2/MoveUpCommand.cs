using System;

namespace LifeGame
{
    internal class MoveUpCommand : ICursorCommand
    {
        private Cursor pointerToCursor;

        public MoveUpCommand(Cursor inputedCurosr)
        {
            pointerToCursor = inputedCurosr;
        }

        public void PerformCommand(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.UpArrow)
            {
                pointerToCursor.YPosition = pointerToCursor.YPosition - 1;
            }
        }
    }
}