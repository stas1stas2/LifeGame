﻿using System;

namespace LifeGame
{
    internal class UniverseWithCursor : ChangeableUniverse
    {
        private const int countOfCommands = 6;
        private ICursorCommand[] commandForCursorsMove;
        private Cursor cursorForField;
        private IsGameHaveToStart lifeOfUniverse = new IsGameHaveToStart();

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
                new StartUniverseLifeCommand(LifeOfUniverse)
            };
        }

        public Cursor CursorInfo
        {
            get { return cursorForField; }
        }

        protected IsGameHaveToStart LifeOfUniverse
        {
            get { return lifeOfUniverse; }
        }

        public void PerformCommand(ConsoleKey inputedSymbol)
        {
            for (int i = 0; i < countOfCommands; i++)
            {
                commandForCursorsMove[i].PerformCommand(inputedSymbol);
            }
        }
    }
}