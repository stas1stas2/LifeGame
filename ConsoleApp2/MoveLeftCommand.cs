using System;

namespace LifeGame
{
    class MoveLeftCommand : IMoveCommand
    {
        public MoveLeftCommand(Cursor inputedCurosr) : base(inputedCurosr)
        {
        }

        public override void Move(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.LeftArrow)
            {
                SetXCordinate(GetCursor.XPosition - 1);
            }
        }
    }
}
