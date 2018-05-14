namespace LifeGame
{
    internal class IsGameHaveToStart
    {
        private bool gameState = false;

        public IsGameHaveToStart()
        {
        }

        public bool ReturnGameState
        {
            get { return gameState; }
        }

        public void SetStateTrue()
        {
            gameState = true;
        }
    }
}