﻿using System;
using System.Threading;

namespace Universe
{
    internal class LifeGameInterface : UniverseWithGameRules
    {
        public LifeGameInterface(int width, int height) : base(width, height)
        {
        }

        public void StartGame()
        {
            bool IsGameContinue = true;
            bool spaceWereTaped = false;
            int generations = 0;
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
                PrintFieldWithCursor();
            }
            while (IsGameContinue)
            {
                
                IsGameContinue = ChangeUniverseField();
                Console.Clear();
                Console.Write("Generations: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{generations}\n");
                PrintFieldWithoutCursor();
                Thread.Sleep(300);
                generations++;
            }
        }
    }
}
