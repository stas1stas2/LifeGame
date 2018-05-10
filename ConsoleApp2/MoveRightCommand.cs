using System;

namespace LifeGame
{
    class MoveRightCommand : IMoveCommand
    {
        public MoveRightCommand(Cursor inputedCurosr) : base(inputedCurosr)
        {
        }

        public override void Move(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.RightArrow)
            {
                SetXCordinate(GetCursor.XPosition + 1);
            }
        }
    }
}