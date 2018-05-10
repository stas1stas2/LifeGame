using System;

namespace LifeGame
{
    class MoveUpCommand : IMoveCommand
    {
        public MoveUpCommand(Cursor inputedCurosr) : base(inputedCurosr)
        {
        }

        public override void Move(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.UpArrow)
            {
                SetYCordinate(GetCursor.YPosition - 1);
            }
        }
    }
}