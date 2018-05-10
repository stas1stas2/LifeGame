using System;

namespace LifeGame
{
    class MoveDownCommand : IMoveCommand
    {
        public MoveDownCommand(Cursor inputedCurosr) : base(inputedCurosr)
        {
        }

        public override void Move(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.DownArrow)
            {
                SetYCordinate(GetCursor.YPosition + 1);
            }
        }
    }
}