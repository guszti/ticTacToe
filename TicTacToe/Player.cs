using System;
using System.Collections.Generic;

namespace TicTacToe
{
	public class Player
	{
		protected int x;
		protected int y;
        
        public Player(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
        
        public bool CheckPlace(List<Player> move)
        {

            foreach (Player p in move)
            {
				if (p.x == this.x && p.y == this.y)
                {
                    return false;
                }
            }
            return true;
        }

        public virtual void AddMove(string[,] table, int id)
        {
            if (this.x == 2 && this.y == 1) //line 1
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
            else if (this.x == 6 && this.y == 1)
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
            else if (this.x == 10 && this.y == 1)
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
            else if (this.x == 2 && this.y == 3)    //line 2
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
            else if (this.x == 6 && this.y == 3)
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
            else if (this.x == 10 && this.y == 3)
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
            else if (this.x == 2 && this.y == 5) //line 3
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
            else if (this.x == 6 && this.y == 5)
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
            else if (this.x == 10 && this.y == 5)
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