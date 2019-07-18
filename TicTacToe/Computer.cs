using System;

namespace TicTacToe
{
    public class Computer : Player
    {
        public Computer(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public override int X
        {
            get { return x; }
            set { x = value; }
        }

        public override int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override bool CheckPlace(string[,] moves)
        {
            if (!moves[x, y].Equals(" "))
            {
                return false;
            }
            return true;
        }
        
        public Computer CalculateMove(string[,] table)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.CheckPlace((Game._Table)))
                    {
                        return new Computer(this.x, this.y);
                    }

                    this.y++;
                }

                this.y = 0;
                this.x++;
            }
            
            return new Computer(0, 0);
        }

        public override void AddMove(string[,] table, int id)
        {
            if (id % 2 == 0)
            {
                table[x, y] = "X";
            }
            else
            {
                table[x, y] = "O";
            }

            if (this.x == 0 && this.y == 0) //line 1
            {
                Console.SetCursorPosition(2, 1);
                Console.Write("O");
            }
            else if (this.x == 1 && this.y == 0)
            {
                Console.SetCursorPosition(6, 1);
                Console.Write("O");
            }
            else if (this.x == 2 && this.y == 0)
            {
                Console.SetCursorPosition(10, 1);
                Console.Write("O");
            }
            else if (this.x == 0 && this.y == 1) //line 2
            {
                Console.SetCursorPosition(2, 3);
                Console.Write("O");
            }
            else if (this.x == 1 && this.y == 1)
            {
                Console.SetCursorPosition(6, 3);
                Console.Write("O");
            }
            else if (this.x == 2 && this.y == 1)
            {
                Console.SetCursorPosition(10, 3);
                Console.Write("O");
            }
            else if (this.x == 0 && this.y == 2) //line 3
            {
                Console.SetCursorPosition(2, 5);
                Console.Write("O");
            }
            else if (this.x == 1 && this.y == 2)
            {
                Console.SetCursorPosition(6, 5);
                Console.Write("O");
            }
            else if (this.x == 2 && this.y == 2)
            {
                Console.SetCursorPosition(10, 5);
                Console.Write("O");
            }
        }
    }
}