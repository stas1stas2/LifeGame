using System;

namespace LifeGame
{
    internal class ChangeCellCommand : ICursorCommand
    {
        private UniverseCell[][] currentField;
        private Cursor pointerToCursor;

        public ChangeCellCommand(Cursor inputedCurosr, UniverseCell[][] inputedField) 
        {
            pointerToCursor =inputedCurosr;
            currentField = inputedField;
        }

        public void PerformCommand(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.Enter)
            {
                currentField[pointerToCursor.YPosition][pointerToCursor.XPosition].ChangeValue();
            }
        }
    }
}