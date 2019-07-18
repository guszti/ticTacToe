using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public abstract class Player
    {
        protected int x;
        protected int y;

        public abstract int X { get; set; }
        public abstract  int Y { get; set; }
        
        
        public abstract bool CheckPlace(string[,] moves);
        public abstract void AddMove(string[,] table, int id);
    }
}