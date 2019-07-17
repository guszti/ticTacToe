using System;

namespace TicTacToe
{
    public class Computer : Human
    {
        public Computer(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }

        public Computer CalculateMove(string[,] table)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.CheckPlace((Game._Moves)))
                    {
                        return new Computer(x, y);
                    }

                    y += 2;
                }

                y = 1;
                x += 4;
            }
            
            return new Computer(0, 0);
        }

        public override void AddMove(string[,] table, int id)
        {
            if (this.x == 2 && this.y == 1) //line 1
            {
                table[0, 0] = "O";
            }
            else if (this.x == 6 && this.y == 1)
            {
                table[0, 1] = "O";
            }
            else if (this.x == 10 && this.y == 1)
            {
                table[0, 2] = "O";
            }
            else if (this.x == 2 && this.y == 3) //line 2
            {
                table[1, 0] = "O";
            }
            else if (this.x == 6 && this.y == 3)
            {
                table[1, 1] = "O";
            }
            else if (this.x == 10 && this.y == 3)
            {
                table[1, 2] = "O";
            }
            else if (this.x == 2 && this.y == 5) //line 3
            {
                table[2, 0] = "O";
            }
            else if (this.x == 6 && this.y == 5)
            {
                table[2, 1] = "O";
            }
            else if (this.x == 10 && this.y == 5)
            {
                table[2, 2] = "O";
            }
                        
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }
    }
}