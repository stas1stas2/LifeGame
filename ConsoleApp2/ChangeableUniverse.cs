using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    internal class ChangeableUniverse : PrintAbleUniverse
    {
        public ChangeableUniverse(int width, int height) : base(width, height)
        {
        }

        public void ChangeCell(uint xCoord, uint yCoord)
        {
            if (xCoord >= Width)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (yCoord >= Heigth)
            {
                throw new ArgumentOutOfRangeException();
            }
            universeField[yCoord][xCoord].ChangeValue();
        }
    }
}
