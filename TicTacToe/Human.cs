using System;
using System.Collections.Generic;

namespace TicTacToe
{
	public class Human : Player
	{
        public Human(int x, int y)
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
        }
    }
}