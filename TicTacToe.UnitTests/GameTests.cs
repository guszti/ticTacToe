using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameStateTests
    {
        [Test]
        public void GameState_Works()
        {
            string[,] table = {{" "," "," "},
                               {" "," "," "},
                               {" "," "," "}
                              };
            
            Assert.IsTrue(Game.GameState(table));
            
            table = new [,] {{" "," "," "},
                             {" ","O"," "},
                             {"X"," ","O"}
                            };
                        
            Assert.IsTrue(Game.GameState(table));
            
            table = new [,] {{"X"," "," "},
                             {"X"," "," "},
                             {"X"," "," "}
                            };
            
            Assert.IsFalse(Game.GameState(table));
            
            table = new [,] {{" ","O"," "},
                             {"X","O"," "},
                             {"X","O"," "}
                            };
            
            Assert.IsFalse(Game.GameState(table));
            
            table = new [,] {{" ","O","X"},
                             {"X","X"," "},
                             {"X","O"," "}
                            };
            
            Assert.IsFalse(Game.GameState(table));

            table = new [,] {{" ","O","X"},
                             {"X","X","X"},
                             {" ","O"," "}
                            };
            
            Assert.IsFalse(Game.GameState(table));
            
            table = new [,] {{" ","O","X"},
                             {"X","X"," "},
                             {"O","O","O"}
                            };
            
            Assert.IsFalse(Game.GameState(table));
        }
    }

    [TestFixture]
    public class FakeInputForGameMenuTest : IPlayerInput
    {
        public ConsoleKey GetInput(){
            return ConsoleKey.D1;
        }
        
        [Test]
        public void GameMenu_handles_key()
        {
            Assert.AreEqual(1, Game.GameMenu(new FakeInputForGameMenuTest()));
        }
    }
}