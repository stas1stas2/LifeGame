using System;
using System.Threading;

namespace LifeGame
{
    internal class LifeGameInterface : UniverseWithGameRules
    {
        private int countOfGenerations = 0;
        private int pauseTime = 300;

        public LifeGameInterface(int width, int height) : base(width, height)
        {
        }

        public void PrintGeneration()
        {
            Console.Write("Generations: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{countOfGenerations}");
        }

        public void StartGame()
        {
            bool isGameContinue = true;

            PrintGeneration();
            PrintFieldWithCursor();
            
            while (!LifeOfUniverse.IsGameHasToRun)
            {
                ConsoleKey pressedKey = Console.ReadKey().Key;
                PerformCommand(pressedKey);
                Console.Clear();
                PrintGeneration();
                PrintFieldWithCursor();
            }

            while (isGameContinue)
            {
                countOfGenerations++;
                isGameContinue = ChangeUniverseField();
                Console.Clear();
                PrintGeneration();
                PrintFieldWithoutCursor();
                Thread.Sleep(pauseTime);
            }
        }
    }
}