using System;

namespace LifeGame
{
    internal abstract class IMoveCommand
    {
        private Cursor pointerToCursor;

        public IMoveCommand(Cursor currentCursor)
        {
            pointerToCursor = currentCursor;
        }

        public abstract void Move(ConsoleKey commandCharacter);

        protected Cursor GetCursor
        {
            get { return pointerToCursor; }
        }

        protected void SetXCordinate (int x)
        {
            pointerToCursor.XPosition = x;
        }
        protected void SetYCordinate(int y)
        {
            pointerToCursor.YPosition = y;
        }
    }
}
