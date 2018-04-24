using System;

namespace Universe
{
    internal class FieldMemento
    {
        private UniverseCell[][][] states;
        int countOfItems;

        public FieldMemento()
        {
            states = new UniverseCell[10][][];
            countOfItems = 0;
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

        public int CountOfItems
        {
            get { return countOfItems; }
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
    }
}
