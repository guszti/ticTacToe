using System;

namespace TicTacToe
{
    public class Computer : Player
    {
        public Computer(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }

        public override void AddMove(string[,] table, int id)
        {
            
        }
    }
}