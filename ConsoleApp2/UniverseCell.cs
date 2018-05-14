namespace LifeGame
{
    internal class UniverseCell
    {
        private bool isActive;

        public UniverseCell()
        {
            isActive = false;
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public void ChangeValue()
        {
            isActive = !isActive;
        }

    }
}