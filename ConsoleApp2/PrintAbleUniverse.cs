using System;

namespace LifeGame
{
    internal class PrintAbleUniverse : UniverseWithCursor
    {
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
                        Console.Write("+");
                    }
                }
                else
                {
                    for (int i2 = -1; i2 <= this.Width; i2++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (i2 == -1 || i2 == this.Width)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            if (universeField[i][i2].IsActive)
                            {
                                if (CursorCordX == i2 && CursorCordY == i)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("0");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("O");
                                }
                            }
                            else
                            {
                                if (CursorCordX == i2 && CursorCordY == i)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("X");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
                Console.Write("\n");
            }
        }

        public void PrintFieldWithoutCursor()
        {
            for (int i = -1; i <= this.Heigth; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (i == -1 || i == this.Heigth)
                {
                    for (int i3 = 0; i3 <= this.Width + 1; i3++)
                    {
                        Console.Write("+");
                    }
                }
                else
                {
                    for (int i2 = -1; i2 <= this.Width; i2++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (i2 == -1 || i2 == this.Width)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            if (universeField[i][i2].IsActive)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("O");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" ");
                            }
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
