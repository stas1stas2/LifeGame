using System;
using System.Threading;

namespace LifeGame
{
    internal class LifeGameInterface : UniverseWithGameRules
    {
        private int generations = 0;
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
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    MoveCursorLower();
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    MoveCursorUpper();
                }
                else if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    MoveCursorLeft();
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    MoveCursorRight();
                }
                else if (pressedKey.Key == ConsoleKey.Spacebar)
                {
                    spaceWereTaped = true;
                }
                else if (pressedKey.Key == ConsoleKey.Enter)
                {
                    universeField[CursorCordY][CursorCordX].ChangeValue();
                }
                Console.Clear();
                PrintGeneration();
                PrintFieldWithCursor();
            }
            while (IsGameContinue)
            {
                
                IsGameContinue = ChangeUniverseField();
                Console.Clear();
                PrintGeneration();
                PrintFieldWithoutCursor();
                Thread.Sleep(300);
                generations++;
            }
        }
    }
}