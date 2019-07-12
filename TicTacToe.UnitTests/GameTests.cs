using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameTests
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

        [Test]
        [TestCase(ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3)]
        public void GameMenuHandlesKey(ConsoleKey k1, ConsoleKey k2, ConsoleKey k3)
        {
            Assert.AreEqual(k1, Game.GameMenu());
        }
    }
}