using System;
namespace LifeGame
{
    internal class UniverseWithCursor : ChangeableUniverse
    {
        private const int countOfCommands = 6;
        private Cursor cursorForField;
        private ICursorCommand[] commandForCursorsMove;
        protected IsUniverseHaveToLive LifeOfUniverse = new IsUniverseHaveToLive();

        public UniverseWithCursor(int width, int height) : base(width, height)
        {
            cursorForField = new Cursor(width, height);

            commandForCursorsMove = new ICursorCommand[countOfCommands];
            commandForCursorsMove[0] = new MoveLeftCommand(cursorForField);
            commandForCursorsMove[1] = new MoveRightCommand(cursorForField);
            commandForCursorsMove[2] = new MoveDownCommand(cursorForField);
            commandForCursorsMove[3] = new MoveUpCommand(cursorForField);
            commandForCursorsMove[4] = new ChangeCellCommand(cursorForField, FieldOfUniverse);
            commandForCursorsMove[5] = new StartUniverseLifeCommand(LifeOfUniverse);
        }

        public void MoveCursor(ConsoleKey inputedSymbol)
        {
            for (int i = 0; i < countOfCommands ; i++)
            {
                 commandForCursorsMove[i].PerformCommand(inputedSymbol);
            }
        }

        public Cursor GetCursor
        {
            get
            {
                return cursorForField;
            }
        }
    }
}