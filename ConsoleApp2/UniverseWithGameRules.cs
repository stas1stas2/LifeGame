namespace Universe
{
    class UniverseWithGameRules : UniverseField
    {
        private bool isFieldWereChanged = true;
        private UniverseCell[][] newField;
        private FieldMemento states;

        public UniverseWithGameRules(int width, int height) : base(width, height)
        {
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

        public bool IsFieldWereChanged
        {
            get { return isFieldWereChanged; }
        }

        public void ClearField()
        {
            for (int i = 0; i < Heigth; i++)
            {
                for (int i2 = 0; i2 < Width; i2++)
                {
                    newField[i][i2].IsActive = false;
                }
            }
        }

        public bool ChangeUniverseField()
        {
            if (isFieldWereChanged)
            {
                isFieldWereChanged = false;
                for (int i  = 0; i < Heigth; i++)
                {
                    for (int i2 = 0; i2 < Width; i2++)
                    {
                        int countOfNeighbors = GetCountOfNeighbors(i, i2);
                        if (universeField[i][i2].IsActive && (countOfNeighbors < 2 || countOfNeighbors > 3))
                        {
                            newField[i][i2].IsActive = false;
                            isFieldWereChanged = true;
                        }
                        else if (!universeField[i][i2].IsActive && (countOfNeighbors >= 2 && countOfNeighbors <= 3))
                        {
                            newField[i][i2].IsActive = true;
                            isFieldWereChanged = true;
                        }
                    }
                }

                states.AddState(GetFieldClone());
                UniverseCell[][] arrayForSwap = universeField;
                universeField = newField;
                newField = arrayForSwap;
                ClearField();

                if (!isFieldWereChanged)
                {
                    for (int i = states.CountOfItems-1; i > 0; i++)
                    {
                       
                    }
                }
            }
            return isFieldWereChanged;
        }

        private int GetCountOfNeighbors(int Ycord, int Xcord)
        {
            int countOfneighbors = 0;

            if (Ycord > 0)
            {
                if (universeField[Ycord - 1][Xcord].IsActive)
                {
                    countOfneighbors++;
                }
                if (Xcord > 0)
                {
                    if (universeField[Ycord - 1][Xcord - 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
                if (Xcord + 1 < Width)
                {
                    if (universeField[Ycord - 1][Xcord + 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
            }
            if (Ycord + 1 < Heigth)
            {
                if (universeField[Ycord + 1][Xcord].IsActive)
                {
                    countOfneighbors++;
                }
                if (Xcord > 0)
                {
                    if (universeField[Ycord + 1][Xcord - 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
                if (Xcord + 1 < Width)
                {
                    if (universeField[Ycord + 1][Xcord + 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
            }
            if (Xcord > 0)
            {
                if (universeField[Ycord][Xcord - 1].IsActive)
                {
                    countOfneighbors++;
                }
            }
            if (Xcord + 1 < Width)
            {
                if (universeField[Ycord][Xcord + 1].IsActive)
                {
                   countOfneighbors++;
                }
            }
            return countOfneighbors;
        }
    }
}
