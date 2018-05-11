using System;

namespace LifeGame
{
    class StartUniverseLifeCommand : ICursorCommand
    {
        private IsGameHaveToStart currentLifeOfUniverse;

        public StartUniverseLifeCommand(IsGameHaveToStart LifeOfUniverse)
        {
            currentLifeOfUniverse = LifeOfUniverse;
        }

        public void PerformCommand(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.Spacebar)
            {
                currentLifeOfUniverse.SetStateTrue();
            }
        }
    }
}
