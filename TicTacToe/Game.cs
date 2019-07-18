using System;

namespace TicTacToe
{
	public class Game : IPlayerInput
	{
		private  static bool _gameOn;
		private  static int _x;
		private  static int _y;
		private  static int _player;
		private  static ConsoleKeyInfo _keyInfo;
		private  static string[,] _table;

		public static string[,] _Table
		{
			get { return _table; }
		}

		public ConsoleKey GetInput()
		{
			return Console.ReadKey().Key;
		}
		
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

		public static bool GameState(string[,] coordinates)
		{
			string[] tripleRow = new string[3];
            string[] tripleCol = new string[3];
            int evenGame = 0;

            for (int i = 0; i < 3; i++)
            {
	            for (int j = 0; j < 3; j++)
	            {
		            tripleRow[j] = coordinates[i, j];
		            tripleCol[j] = coordinates[j, i];

		            if (!coordinates[i, j].Equals(" "))
		            {
			            evenGame++;
		            }
	            }

	            if (!tripleRow[0].Equals(" ") && tripleRow[0].Equals(tripleRow[1]) && tripleRow[0].Equals(tripleRow[2]))
	            {
		            try
		            {
			            Console.SetCursorPosition(0, 7);
		            }
		            catch (Exception ex)
		            {
			            Console.WriteLine(ex.Message);
		            }
	            
		            Console.WriteLine("The winner is {0}!", tripleRow[0]);
		            
		            return false;
	            }
	            if (!tripleCol[0].Equals(" ") && tripleCol[0].Equals(tripleCol[1]) && tripleCol[0].Equals(tripleCol[2]))
	            {
		            try
		            {
			            Console.SetCursorPosition(0, 7);
		            }
		            catch (Exception ex)
		            {
			            Console.WriteLine(ex.Message);
		            }
	            
		            Console.WriteLine("The winner is {0}!", tripleCol[0]);
		            
		            return false;
	            }
	            if (!coordinates[1, 1].Equals(" ") && (coordinates[1, 1].Equals(coordinates[0, 0]) && coordinates[1, 1].Equals(coordinates[2, 2]) || (coordinates[1, 1].Equals(coordinates[0, 2]) && coordinates[1, 1].Equals(coordinates[2, 0]))))
	            {
		            try
		            {
			            Console.SetCursorPosition(0, 7);
		            }
		            catch (Exception ex)
		            {
			            Console.WriteLine(ex.Message);
		            }
	            
		            Console.WriteLine("The winner is {0}!", coordinates[1, 1]);
		            
		            return false;
	            }
            }

            if (evenGame == 9)
            {
	            try
	            {
		            Console.SetCursorPosition(0, 7);
	            }
	            catch (Exception ex)
	            {
		            Console.WriteLine(ex.Message);
	            }
	            
	            Console.WriteLine("Game is even!");
		            
	            return false;
            }
            
            return true;
		}

		public static int GameMenu(IPlayerInput pinput)
		{
			Console.WriteLine("1: New PvP game | 2: New PvE game | 3: Exit");
			ConsoleKey k = pinput.GetInput();
			
			switch(k)
			{
				case ConsoleKey.D1:
					try
					{
						Console.Clear();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
					return 1;
				case ConsoleKey.D2:
					try
					{
						Console.Clear();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
					return 2;
				case ConsoleKey.D3:
					try
					{
						Console.Clear();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
					return 3;
				default:
					return 3;
			}
		}

		private static void SinglePlayer()
		{
			DrawTable();
			Console.SetCursorPosition(_x, _y);
			
			Human playerH = new Human(1, 1);
			
			while (_gameOn)
			{
				if (_player % 2 == 0)
				{
					_keyInfo = Console.ReadKey(true);

					switch (_keyInfo.Key)
					{
						case ConsoleKey.DownArrow:
							if (_y < 5)
							{
								_y += 2;
								playerH.Y++;
								Console.SetCursorPosition(_x, _y);
							}
							break;
						case ConsoleKey.UpArrow:
							if (_y > 1)
							{
								_y -= 2;
								playerH.Y--;
								Console.SetCursorPosition(_x, _y);
							}
							break;
						case ConsoleKey.RightArrow:
							if (_x < 10)
							{
								_x += 4;
								playerH.X++;
								Console.SetCursorPosition(_x, _y);
							}
							break;
						case ConsoleKey.LeftArrow:
							if (_x > 2)
							{
								_x -= 4;
								playerH.X--;
								Console.SetCursorPosition(_x, _y);	
							}
							break;
						case ConsoleKey.Enter:
							if (playerH.CheckPlace(_table) == true)
							{
								playerH.AddMove(_table, _player);

								Console.Write("X");
									
								playerH = new Human(1, 1);
							
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
				else
				{
					Computer playerC = new Computer(0, 0);
					playerC = playerC.CalculateMove(_table);
					playerC.AddMove(_table, _player);
					
					_x = 6; _y = 3;
					Console.SetCursorPosition(_x, _y);
					
					_gameOn = GameState(_table);

					_player++;
				}
			}
			
			RunGame();
		}

		private static void PlayerVsPlayer()
		{
			DrawTable();
			Console.SetCursorPosition(_x, _y);
			
			Human playerH = new Human(1, 1);

			while (_gameOn)
			{
				_keyInfo = Console.ReadKey(true);

				switch (_keyInfo.Key)
				{
					case ConsoleKey.DownArrow:
						if (_y < 5)
						{
							_y += 2;
							playerH.Y++;
							Console.SetCursorPosition(_x, _y);
						}
						break;
					case ConsoleKey.UpArrow:
						if (_y > 1)
						{
							_y -= 2;
							playerH.Y--;
							Console.SetCursorPosition(_x, _y);
						}
						break;
					case ConsoleKey.RightArrow:
						if (_x < 10)
						{
							_x += 4;
							playerH.X++;
							Console.SetCursorPosition(_x, _y);
						}
						break;
					case ConsoleKey.LeftArrow:
						if (_x > 2)
						{
							_x -= 4;
							playerH.X--;
							Console.SetCursorPosition(_x, _y);	
						}
						break;
					case ConsoleKey.Enter:
						if (playerH.CheckPlace(_table) == true)
						{
							playerH.AddMove(_table, _player);

							if (_player % 2 == 0)
							{
								Console.Write("X");
							}
							else
							{
								Console.Write("O");
							}
							
							playerH = new Human(1, 1);
							
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
			_table = new [,] {{" "," "," "},
							  {" "," "," "},
							  {" "," "," "}
			};
			
			switch (GameMenu(new Game()))
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