using System;

namespace LifeGame
{
    class StartUniverseLifeCommand : ICursorCommand
    {
        private IsUniverseHaveToLive currentLifeOfUniverse;

        public StartUniverseLifeCommand(IsUniverseHaveToLive LifeOfUniverse)
        {
            currentLifeOfUniverse = LifeOfUniverse;
        }

        public void PerformCommand(ConsoleKey commandCharacter)
        {
            if (commandCharacter == ConsoleKey.Spacebar)
            {
                currentLifeOfUniverse.boolean = true;
            }
        }
    }
}
