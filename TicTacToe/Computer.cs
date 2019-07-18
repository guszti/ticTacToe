using System;
using System.Collections.Generic;

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
        }

        public override int Y
        {
            get { return y; }
        }

        public override bool CheckPlace(List<Player> move)
        {
            foreach (var p in move)
            {
                if (p.X == this.x && p.Y == this.y)
                {
                    return false;
                }
            }
            return true;
        }
        
        public Computer CalculateMove(string[,] table)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.CheckPlace((Game._Moves)))
                    {
                        return new Computer(this.x, this.y);
                    }

                    this.y += 2;
                }

                this.y = 1;
                this.x += 4;
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