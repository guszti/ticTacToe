using System;
using System.Collections.Generic;

namespace TicTacToe
{
	public static class Game
	{                      
		private static void DrawTable()
		{
            Console.Write(
                "+---+---+---+\n" +
                "|   |   |   |\n" +
                "+---+---+---+\n" +
                "|   |   |   |\n" +
                "+---+---+---+\n" +
                "|   |   |   |\n" +
                "+---+---+---+\n"
            );
        }

		private static bool GameState(string[,] coordinates)
		{
            if (coordinates[0, 0].Equals("X") && coordinates[0, 1].Equals("X") && coordinates[0, 2].Equals("X"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is X!");
                return false;
            }
            if (coordinates[1, 0].Equals("X") && coordinates[1, 1].Equals("X") && coordinates[1, 2].Equals("X"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is X!");
                return false;
            }
            if (coordinates[2, 0].Equals("X") && coordinates[2, 1].Equals("X") && coordinates[2, 2].Equals("X"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is X!");
                return false;
            }
            if (coordinates[0, 0].Equals("X") && coordinates[1, 1].Equals("X") && coordinates[2, 2].Equals("X"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is X!");
                return false;
            }
            if (coordinates[0, 2].Equals("X") && coordinates[1, 1].Equals("X") && coordinates[2, 0].Equals("X"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is X!");
                return false;
            }
            if (coordinates[0, 0].Equals("O") && coordinates[0, 1].Equals("O") && coordinates[0, 2].Equals("O"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is O!");
                return false;
            }
            if (coordinates[1, 0].Equals("O") && coordinates[1, 1].Equals("O") && coordinates[1, 2].Equals("O"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is O!");
                return false;
            }
            if (coordinates[2, 0].Equals("O") && coordinates[2, 1].Equals("O") && coordinates[2, 2].Equals("O"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is O!");
                return false;
            }
            if (coordinates[0, 0].Equals("O") && coordinates[1, 1].Equals("O") && coordinates[2, 2].Equals("O"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is O!");
                return false;
            }
            if (coordinates[0, 2].Equals("O") && coordinates[1, 1].Equals("O") && coordinates[2, 0].Equals("O"))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The winner is O!");
                return false;
            }
            if (!coordinates[0, 0].Equals(" ") && !coordinates[0, 1].Equals(" ") && !coordinates[0, 2].Equals(" ") && !coordinates[1, 0].Equals(" ") && !coordinates[1, 1].Equals(" ") && !coordinates[1, 2].Equals(" ") && !coordinates[2, 0].Equals(" ") && !coordinates[2, 1].Equals(" ") && !coordinates[2, 2].Equals(" "))
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("The game is even!");
                return false;
            }

            return true;
		}
              
		public static void RunGame()
		{
            bool gameOn = true;
            int x = 6;
            int y = 3;
            int player = 0;
            Player playa;
			ConsoleKeyInfo keyInfo;
			List<Player> moves = new List<Player>();
			string[,] table = {{" "," "," "},
							   {" "," "," "},
							   {" "," "," "}
			};

			DrawTable();
			Console.SetCursorPosition(x, y);

			while (gameOn)
            {
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
				{
					case ConsoleKey.DownArrow:
						if (y < 5)
							y += 2;
						Console.SetCursorPosition(x, y);
						break;
					case ConsoleKey.UpArrow:
						if (y > 1)
							y -= 2;
						Console.SetCursorPosition(x, y);
						break;
					case ConsoleKey.RightArrow:
						if (x < 10)
							x += 4;
						Console.SetCursorPosition(x, y);
						break;
					case ConsoleKey.LeftArrow:
						if (x > 2)
							x -= 4;
						Console.SetCursorPosition(x, y);
						break;
					case ConsoleKey.Enter:
						playa = new Player(x, y);
						if (playa.CheckPlace(moves) == true)
						{
							moves.Add(playa);
                            playa.AddMove(table, player);

							if (player % 2 == 0)
							{
								Console.Write("X");
							}
							else
							{
								Console.Write("O");
							}
							
						    x = 6; y = 3;
							Console.SetCursorPosition(x, y);
							player++;
						}
                        gameOn = GameState(table);
						break;
                    case ConsoleKey.Escape:
                        gameOn = false;
                        break;
				}                    
			}

            Console.WriteLine("1: New game  2: Exit");
            keyInfo = Console.ReadKey(true);
            switch(keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    RunGame();
                    break;
                case ConsoleKey.D2:
	                Console.Clear();
                    break;
            }
		}
	}
}