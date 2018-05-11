using System;
namespace LifeGame
{
    internal class UniverseWithCursor : ChangeableUniverse
    {
        private const int countOfCommands = 6;
        private Cursor cursorForField;
        private ICursorCommand[] commandForCursorsMove;
        protected IsGameHaveToStart lifeOfUniverse = new IsGameHaveToStart();

        public UniverseWithCursor(int width, int height) : base(width, height)
        {
            cursorForField = new Cursor(width, height);

            commandForCursorsMove = new ICursorCommand[countOfCommands]
            {
            new MoveLeftCommand(cursorForField),
            new MoveRightCommand(cursorForField),
            new MoveDownCommand(cursorForField),
            new MoveUpCommand(cursorForField),
            new ChangeCellCommand(cursorForField, FieldOfUniverse),
            new StartUniverseLifeCommand(lifeOfUniverse)
            };
        }

        public void PerformCommand(ConsoleKey inputedSymbol)
        {
            for (int i = 0; i < countOfCommands; i++)
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