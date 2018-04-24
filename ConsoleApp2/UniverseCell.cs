namespace LifeGame
{
    internal class UniverseCell
    {
        private bool isActive;

        public UniverseCell()
        {
            isActive = false;
        }

        public void ChangeValue ()
        {
            if (isActive)
            {
                isActive = false;
            }
            else
            {
                isActive = true;
            }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
    }
}
