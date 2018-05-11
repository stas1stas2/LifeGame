using System;

namespace LifeGame
{
    internal class ChangeableUniverse : UniverseField
    {
        public ChangeableUniverse(int width, int height) : base(width, height)
        {
        }

        public void ChangeCell(uint xCordinate, uint yCordinate)
        {
            if (xCordinate >= Width)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (yCordinate >= Heigth)
            {
                throw new ArgumentOutOfRangeException();
            }
            FieldOfUniverse[yCordinate][xCordinate].ChangeValue();
        }
    }
}