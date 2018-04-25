using System;

namespace LifeGame
{
    internal class FieldMemento
    {
        private int countOfItems;
        private UniverseCell[][][] states;

        public FieldMemento()
        {
            states = new UniverseCell[10][][];
            countOfItems = 0;
        }
        public UniverseCell[][] this[int index]
        {
            get
            {
                if (index < countOfItems)
                {
                    return states[index];
                }
                return null;
            }
        }

        public int CountOfItems
        {
            get { return countOfItems; }
        }

        public void AddState(UniverseCell[][] newState)
        {
            if (countOfItems + 1 >= states.Length)
            {
                Array.Resize(ref states, states.Length * 2);
            }
            states[countOfItems] = newState;
            countOfItems++;
        }
    }
}