namespace LifeGame
{
    internal class UniverseField
    {
        private readonly int height;
        private readonly int width;
        private UniverseCell[][] universeField;

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

        protected UniverseCell[][] FieldOfUniverse
        {
            get { return universeField; }
            set { universeField = value; }
        }
        
        public int Heigth
        {
            get { return height; }
        }

        public int Width
        {
            get { return width; }
        }

        public bool IsFieldEqual(UniverseCell[][] fieldForCompare)
        {
            bool isEuqal = true;
            if (fieldForCompare.Length != height)
            {
                isEuqal = false;
            }
            else
            {
                for (int i = 0; i < height && isEuqal; i++)
                { 
                    if (fieldForCompare[i].Length != universeField[i].Length)
                    {
                        isEuqal = false;
                    }
                    else
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (universeField[i][j].IsActive != fieldForCompare[i][j].IsActive)
                            {
                                isEuqal = false;
                                break;
                            }
                        }
                    }
                }
            }
            return isEuqal;
        }

        public UniverseCell[][] GetFieldClone()
        {
            UniverseCell[][] returnValue;
            returnValue = new UniverseCell[height][];
            for (int i = 0; i < height; i++)
            {
                returnValue[i] = new UniverseCell[width];
                for (int i2 = 0; i2 < width; i2++)
                {
                    returnValue[i][i2] = new UniverseCell();
                    returnValue[i][i2].IsActive = universeField[i][i2].IsActive;
                }
            }
            return returnValue;
        }
    }
}