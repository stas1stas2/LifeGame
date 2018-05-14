using System;

namespace LifeGame
{
    internal class MoveLeftCommand : ICursorCommand
    {
        private Cursor pointerToCursor;

        public MoveLeftCommand(Cursor inputedCurosr)
        {
            pointerToCursor = inputedCurosr;
        }

        public void PerformCommand(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.LeftArrow)
            {
                pointerToCursor.XPosition = pointerToCursor.XPosition-1;
            }
        }
    }
}