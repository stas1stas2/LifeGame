using System;

namespace LifeGame
{
    internal class PrintAbleUniverse : UniverseWithCursor
    {
        private char symbolOfBounds = '+';
        private char symbolOfCellWithLife = 'O';
        private char symbolOfCellWithoutLife = ' ';
        private char symbolOfCursor = 'X';

        public PrintAbleUniverse(int width, int height) : base(width, height)
        {
        }

        public void PrintFieldWithCursor()
        {
            for (int i = -1; i <= Heigth; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (i == -1 || i == Heigth)
                {
                    for (int i3 = 0; i3 <= Width + 1; i3++)
                    {
                        Console.Write(symbolOfBounds);
                    }
                }
                else
                {
                    for (int i2 = -1; i2 <= Width; i2++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (i2 == -1 || i2 == Width)
                        {
                            Console.Write(symbolOfBounds);
                        }
                        else
                        {
                            if (CursorInfo.XPosition == i2 && CursorInfo.YPosition == i)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(symbolOfCursor);
                            }
                            else
                            {
                                if (FieldOfUniverse[i][i2].IsActive)
                                {
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(symbolOfCellWithLife);
                                    }
                                }
                                else
                                {
                                    Console.Write(symbolOfCellWithoutLife);
                                }
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public void PrintFieldWithoutCursor()
        {
            for (int i = -1; i <= Heigth; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (i == -1 || i == Heigth)
                {
                    for (int i3 = 0; i3 <= Width + 1; i3++)
                    {
                        Console.Write(symbolOfBounds);
                    }
                }
                else
                {
                    for (int i2 = -1; i2 <= Width; i2++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (i2 == -1 || i2 == Width)
                        {
                            Console.Write(symbolOfBounds);
                        }
                        else
                        {
                            if (FieldOfUniverse[i][i2].IsActive)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(symbolOfCellWithLife);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(symbolOfCellWithoutLife);
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}