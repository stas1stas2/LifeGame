using System;

namespace LifeGame
{
    internal class ChangeableUniverse : UniverseField
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