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

        public UniverseCell[][] GetFieldClone()
        {
            UniverseCell[][] fieldsClone;
            fieldsClone = new UniverseCell[height][];
            for (int i = 0; i < height; i++)
            {
                fieldsClone[i] = new UniverseCell[width];
                for (int i2 = 0; i2 < width; i2++)
                {
                    fieldsClone[i][i2] = new UniverseCell();
                    fieldsClone[i][i2].IsActive = universeField[i][i2].IsActive;
                }
            }
            return fieldsClone;
        }

        public bool IsFieldEqual(UniverseCell[][] fieldForCompare)
        {
            bool isEqual = true;
            if (fieldForCompare.Length != height)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < height && isEqual; i++)
                { 
                    if (fieldForCompare[i].Length != universeField[i].Length)
                    {
                        isEqual = false;
                    }
                    else
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (universeField[i][j].IsActive != fieldForCompare[i][j].IsActive)
                            {
                                isEqual = false;
                                break;
                            }
                        }
                    }
                }
            }
            return isEqual;
        }
    }
}