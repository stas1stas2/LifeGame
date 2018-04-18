using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    class UniverseWithGameRules : UniverseField
    {
        private bool isFieldWereChanged = true;
        private UniverseCell[][] newField;

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

        public void ChangeUniverseField()
        {
            if (!isFieldWereChanged)
            {
                return;
            }
            
            isFieldWereChanged = false;
        }

        private int GetCountOfNeighbors()
        {
            int countOfneighbors = 0;
            for (int i = 0; i < Heigth; i++)
            {
                for (int i2 = 0; i2 < Width; i2++)
                {
                    if (i > 0)
                    {
                        if (universeField[i-1][i2].IsActive)
                        {
                            countOfneighbors++;
                        }
                        if (i2 > 0)
                        {
                            if (universeField[i - 1][i2 - 1].IsActive)
                            {
                                countOfneighbors++;
                            }
                        }
                        if (i2+1 < Width)
                        {
                            if (universeField[i - 1][i2 + 1].IsActive)
                            {
                                countOfneighbors++;
                            }
                        } 
                    }
                    if (i+1 < Heigth)
                    {
                        if (universeField[i + 1][i2].IsActive)
                        {
                            countOfneighbors++;
                        }
                        if (i2 > 0)
                        {
                            if (universeField[i + 1][i2 - 1].IsActive)
                            {
                                countOfneighbors++;
                            }
                        }
                        if (i2 + 1 < Width)
                        {
                            if (universeField[i + 1][i2 + 1].IsActive)
                            {
                                countOfneighbors++;
                            }
                        }
                    }
                    if (i2 > 0)
                    {
                        if (universeField[i][i2 - 1].IsActive)
                        {
                            countOfneighbors++;
                        }
                    }
                    if (i2 + 1 < Width)
                    {
                        if (universeField[i][i2 + 1].IsActive)
                        {
                            countOfneighbors++;
                        }
                    }
                }
            }
            return countOfneighbors;
        }
    }
}
