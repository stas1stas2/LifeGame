using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    class PrintAbleUniverse : UniverseWithCursor
    {
        public PrintAbleUniverse(int width, int height) : base(width, height)
        {
        }

        public void PrintField()
        {
            for (int i = -1; i <= this.Heigth; i++)
            {
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
                                    Console.Write("0");
                                }
                                else
                                {
                                    Console.Write("O");
                                }
                            }
                            else
                            {
                                if (CursorCordX == i2 && CursorCordY == i)
                                {
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
    }
}
