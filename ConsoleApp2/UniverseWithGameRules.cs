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

        private int GetCountOfNeighbors(int yCordinate, int xCordinate)
        {
            int countOfneighbors = 0;

            if (yCordinate > 0)
            {
                if (FieldOfUniverse[yCordinate - 1][xCordinate].IsActive)
                {
                    countOfneighbors++;
                }
                if (xCordinate > 0)
                {
                    if (FieldOfUniverse[yCordinate - 1][xCordinate - 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
                if (xCordinate + 1 < Width)
                {
                    if (FieldOfUniverse[yCordinate - 1][xCordinate + 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
            }
            if (yCordinate + 1 < Heigth)
            {
                if (FieldOfUniverse[yCordinate + 1][xCordinate].IsActive)
                {
                    countOfneighbors++;
                }
                if (xCordinate > 0)
                {
                    if (FieldOfUniverse[yCordinate + 1][xCordinate - 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
                if (xCordinate + 1 < Width)
                {
                    if (FieldOfUniverse[yCordinate + 1][xCordinate + 1].IsActive)
                    {
                        countOfneighbors++;
                    }
                }
            }
            if (xCordinate > 0)
            {
                if (FieldOfUniverse[yCordinate][xCordinate - 1].IsActive)
                {
                    countOfneighbors++;
                }
            }
            if (xCordinate + 1 < Width)
            {
                if (FieldOfUniverse[yCordinate][xCordinate + 1].IsActive)
                {
                   countOfneighbors++;
                }
            }
            return countOfneighbors;
        }
    }
}