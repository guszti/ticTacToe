using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameStateTests
    {
        [Test]
        public void IfGameStateWorks()
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
        public void GameMenuHandlesKey()
        {
            Assert.AreEqual(1, Game.GameMenu(new FakeInputForGameMenuTest()));
        }
    }
}