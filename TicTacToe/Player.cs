using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public abstract class Player
    {
        protected int x;
        protected int y;

        public abstract int X { get; }
        public abstract  int Y { get; }
        
        
        public abstract bool CheckPlace(List<Player> move);
        public abstract void AddMove(string[,] table, int id);
    }
}