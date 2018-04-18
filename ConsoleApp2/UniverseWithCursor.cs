using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    class UniverseWithCursor : ChangeableUniverse
    {
        private int cursorCordX;
        private int cursorCordY;

        public UniverseWithCursor(int width, int height) : base(width, height)
        {
            cursorCordX = 0;
            cursorCordY = 0;
    }

        public int CursorCordX
        {
            get { return cursorCordX; }
        }

        public int CursorCordY
        {
            get { return cursorCordY; }
        }

        public void MoveCursorLeft()
        {
            if (cursorCordX - 1 >= 0)
            {
                cursorCordX--;
            }
        }

        public void MoveCursorRight()
        {
            if (cursorCordX + 1 < Width)
            {
                cursorCordX++;
            }
        }

        public void MoveCursorUpper()
        {
            if (cursorCordY - 1 >= 0)
            {
                cursorCordY--;
            }
        }

        public void MoveCursorLower()
        {
            if (cursorCordY + 1 < Heigth)
            {
                cursorCordY++;
            }
        }
    }
}
