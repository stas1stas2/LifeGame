using System;
using System.Threading;

namespace LifeGame
{
    internal class LifeGameInterface : UniverseWithGameRules
    {
        private int generations = 0;
        private int pauseTime = 300;

        public LifeGameInterface(int width, int height) : base(width, height)
        {
        }

        public void PrintGeneration()
        {
            Console.Write("Generations: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{generations}");
        }

        public void StartGame()
        {
            bool IsGameContinue = true;
            bool spaceWereTaped = false;

            PrintGeneration();
            PrintFieldWithCursor();
            
            while (!spaceWereTaped)
            {
                ConsoleKey pressedKey = Console.ReadKey().Key;
                MoveCursor(pressedKey);
                Console.Clear();
                spaceWereTaped = LifeOfUniverse.boolean;
                PrintGeneration();
                PrintFieldWithCursor();
            }
            while (IsGameContinue)
            {
                generations++;
                IsGameContinue = ChangeUniverseField();
                Console.Clear();
                PrintGeneration();
                PrintFieldWithoutCursor();
                Thread.Sleep(pauseTime);
            }
        }
    }
}