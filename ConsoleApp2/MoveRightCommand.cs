using System;

namespace LifeGame
{
    internal class MoveRightCommand : ICursorCommand
    {
        private Cursor pointerToCursor;

        public MoveRightCommand(Cursor inputedCurosr)
        {
            pointerToCursor = inputedCurosr;
        }

        public void PerformCommand(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.RightArrow)
            {
                pointerToCursor.XPosition = pointerToCursor.XPosition + 1;
            }
        }
    }
}