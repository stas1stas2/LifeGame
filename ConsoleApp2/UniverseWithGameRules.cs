namespace LifeGame
{
    internal class UniverseWithGameRules : PrintAbleUniverse
    {
        private bool isFieldWereChanged = true;
        private UniverseCell[][] newField;
        private FieldMemento states = new FieldMemento();

        public UniverseWithGameRules(int width, int height) : base(width, height)
        {
            newField = new UniverseCell[height][];
            for (int i = 0; i < height; i++)
            {
                newField[i] = new UniverseCell[width];
                for (int i2 = 0; i2 < width; i2++)
                {
                    newField[i][i2] = new UniverseCell();
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
                for (int i = 0; i < Heigth; i++)
                {
                    for (int i2 = 0; i2 < Width; i2++)
                    {
                        int countOfNeighbors = GetCountOfNeighbors(i, i2);
                        if (countOfNeighbors < 2 || countOfNeighbors > 3)
                        {
                            newField[i][i2].IsActive = false;
                            if (FieldOfUniverse[i][i2].IsActive)
                            {
                                isFieldWereChanged = true;
                            }
                        }
                        else if (countOfNeighbors == 3 || (countOfNeighbors == 2 && FieldOfUniverse[i][i2].IsActive))
                        {
                            newField[i][i2].IsActive = true;
                            if (!FieldOfUniverse[i][i2].IsActive)
                            {
                                isFieldWereChanged = true;
                            }
                        }
                    }
                }

                states.AddState(GetFieldClone());
                UniverseCell[][] arrayForSwap = FieldOfUniverse;
                FieldOfUniverse = newField;
                newField = arrayForSwap;
                ClearField();

                for (int i = states.CountOfItems - 1; i >= 0; i--)
                {
                    if (IsFieldEqual(states[i]))
                    {
                        isFieldWereChanged = false;
                        break;
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
                if (FieldOfUniverse[Ycord - 1][Xcord].IsActive)
                {
                    countOfneighbors++;
                }
                if (Xcord > 0)
                {
                    if (FieldOfUniverse[Ycord - 1][Xcord - 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
                if (Xcord + 1 < Width)
                {
                    if (FieldOfUniverse[Ycord - 1][Xcord + 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
            }
            if (Ycord + 1 < Heigth)
            {
                if (FieldOfUniverse[Ycord + 1][Xcord].IsActive)
                {
                    countOfneighbors++;
                }
                if (Xcord > 0)
                {
                    if (FieldOfUniverse[Ycord + 1][Xcord - 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
                if (Xcord + 1 < Width)
                {
                    if (FieldOfUniverse[Ycord + 1][Xcord + 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
            }
            if (Xcord > 0)
            {
                if (FieldOfUniverse[Ycord][Xcord - 1].IsActive)
                {
                    countOfneighbors++;
                }
            }
            if (Xcord + 1 < Width)
            {
                if (FieldOfUniverse[Ycord][Xcord + 1].IsActive)
                {
                   countOfneighbors++;
                }
            }
            return countOfneighbors;
        }
    }
}