using System;

namespace TicTacToe
{
    public class Computer : Player
    {
        public Computer()
        {
        }
        
        public Computer(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }

        public static Computer ClaculateMove(string[,] table)
        {
            bool found = false;
            int x = 0;
            int y = 0;

            while (!found)
            {
                Computer c = new Computer(x, y);

                if (c.CheckPlace(Game._Moves))
                {
                    found = true;
                }
            }

            return new Computer(x, y);
        }

        public override void AddMove(string[,] table, int id)
        {
            Console.WriteLine("Added move!");
        }
    }
}