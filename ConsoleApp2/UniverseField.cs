using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    internal class UniverseField
    {
        private readonly int width;
        private readonly int height;
        protected UniverseCell[][] universeField;

        public UniverseField(int width, int height)
        {
            this.width = width;
            this.height = height;

            universeField = new UniverseCell[height][];
            for (int i = 0; i < height; i++)
            {
                universeField[i] = new UniverseCell[width];
                for (int i2 = 0; i2 < width; i2++)
                {
                    universeField[i][i2] = new UniverseCell();
                }
            }
        }

        public int Width
        {
            get { return width; }
        }
        public int Heigth
        {
            get { return height; }
        }
    }
}
