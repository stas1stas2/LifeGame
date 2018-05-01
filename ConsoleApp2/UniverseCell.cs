namespace LifeGame
{
    internal class UniverseCell
    {
        private bool isActive;

        public UniverseCell()
        {
            isActive = false;
        }

        public void ChangeValue()
        {
            isActive = !isActive;
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
    }
}