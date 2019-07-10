using System;
using System.Collections.Generic;
namespace TicTacToe
{
	public class Player
	{
		private int x;
		private int y;

		public Player(int X, int Y)
		{
			x = X;
			y = Y;
		}

        public int X
		{
			get { return x; }
		}

		public int Y
        {
            get { return y; }
        }

		public bool CheckPlace(List<Player> move)
        {

            foreach (Player p in move)
            {
				if (p.X == this.X && p.Y == this.Y)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddMove(string[,] table, int id)
        {
            if (this.X == 2 && this.Y == 1) //line 1
            {
                if (id % 2 == 0)
                {
                    table[0, 0] = "X";
                }
                else
                {
                    table[0, 0] = "O";
                }
            }
            else if (this.X == 6 && this.Y == 1)
            {
                if (id % 2 == 0)
                {
                    table[0, 1] = "X";
                }
                else
                {
                    table[0, 1] = "O";
                }
            }
            else if (this.X == 10 && this.Y == 1)
            {
                if (id % 2 == 0)
                {
                    table[0, 2] = "X";
                }
                else
                {
                    table[0, 2] = "O";
                }
            }
            else if (this.X == 2 && this.Y == 3)    //line 2
            {
                if (id % 2 == 0)
                {
                    table[1, 0] = "X";
                }
                else
                {
                    table[1, 0] = "O";
                }
            }
            else if (this.X == 6 && this.Y == 3)
            {
                if (id % 2 == 0)
                {
                    table[1, 1] = "X";
                }
                else
                {
                    table[1, 1] = "O";
                }
            }
            else if (this.X == 10 && this.Y == 3)
            {
                if (id % 2 == 0)
                {
                    table[1, 2] = "X";
                }
                else
                {
                    table[1, 2] = "O";
                }
            }
            else if (this.X == 2 && this.Y == 5) //line 3
            {
                if (id % 2 == 0)
                {
                    table[2, 0] = "X";
                }
                else
                {
                    table[2, 0] = "O";
                }
            }
            else if (this.X == 6 && this.Y == 5)
            {
                if (id % 2 == 0)
                {
                    table[2, 1] = "X";
                }
                else
                {
                    table[2, 1] = "O";
                }
            }
            else if (this.X == 10 && this.Y == 5)
            {
                if (id % 2 == 0)
                {
                    table[2, 2] = "X";
                }
                else
                {
                    table[2, 2] = "O";
                }
            }
        }

    }
}