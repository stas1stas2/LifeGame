namespace LifeGame
{
    internal class IsGameHaveToStart
    {
        private bool isGameHasToRun = false;

        public bool IsGameHasToRun
        {
            get { return isGameHasToRun; }
        }

        public void SetStateTrue()
        {
            isGameHasToRun = true;
        }
    }
}