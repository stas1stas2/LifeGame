namespace LifeGame
{
    internal class IsGameHaveToStart
    {
        private bool boolean = false;

        public IsGameHaveToStart()
        {
        }

        public bool ReturnGameState {
            get { return boolean; }
        }

        public void SetStateTrue()
        {
            boolean = true;
        }
    }
}