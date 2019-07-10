using System;
using System.Collections.Generic;

namespace TicTacToe
{
	public static class Game
	{
		private static List<Player> _moves;
		private static bool _gameOn;
		private static int _x;
		private static int _y;
		private static int _player;
		private static Player _playa;
		private static ConsoleKeyInfo _keyInfo;
		private static string[,] _table;
		
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

		private static int GameMenu()
		{
			Console.WriteLine("1: New PvP game 2: New PvE game 3: Exit");
			_keyInfo = Console.ReadKey(true);
			switch(_keyInfo.Key)
			{
				case ConsoleKey.D1:
					Console.Clear();
					return 1;
				case ConsoleKey.D2:
					Console.Clear();
					return 2;
				case ConsoleKey.D3:
					Console.Clear();
					return 3;
				default:
					return 3;
			}
		}

		private static void SinglePlayer()
		{
			Console.WriteLine("Single player game started!");
			
			RunGame();
		}

		private static void PlayerVsPlayer()
		{
			DrawTable();
			Console.SetCursorPosition(_x, _y);
			
			while (_gameOn)
			{
				_keyInfo = Console.ReadKey(true);

				switch (_keyInfo.Key)
				{
					case ConsoleKey.DownArrow:
						if (_y < 5)
							_y += 2;
						Console.SetCursorPosition(_x, _y);
						break;
					case ConsoleKey.UpArrow:
						if (_y > 1)
							_y -= 2;
						Console.SetCursorPosition(_x, _y);
						break;
					case ConsoleKey.RightArrow:
						if (_x < 10)
							_x += 4;
						Console.SetCursorPosition(_x, _y);
						break;
					case ConsoleKey.LeftArrow:
						if (_x > 2)
							_x -= 4;
						Console.SetCursorPosition(_x, _y);
						break;
					case ConsoleKey.Enter:
						_playa = new Player(_x, _y);
						
						if (_playa.CheckPlace(_moves) == true)
						{
							_moves.Add(_playa);
							_playa.AddMove(_table, _player);

							if (_player % 2 == 0)
							{
								Console.Write("X");
							}
							else
							{
								Console.Write("O");
							}
							
							_x = 6; _y = 3;
							Console.SetCursorPosition(_x, _y);
							_player++;
						}
						
						_gameOn = GameState(_table);
						break;
					case ConsoleKey.Escape:
						Console.Clear();
						_gameOn = false;
						break;
				}                    
			}
			
			RunGame();
		}
		
		public static void RunGame()
		{
            _gameOn = true;
            _x = 6;
            _y = 3;
            _player = 0;
			_moves = new List<Player>();
			_table = new [,] {{" "," "," "},
							  {" "," "," "},
							  {" "," "," "}
			};
			
			switch (GameMenu())
			{
				case 1:
					PlayerVsPlayer();
					break;
				case 2:
					SinglePlayer();
					break;
				case 3:
					break;
			}
		}
	}
}