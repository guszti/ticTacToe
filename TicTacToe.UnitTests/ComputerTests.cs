using System.Xml;
using NUnit.Framework;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class CheckPlaceTests
    {
        private Computer comp;
        
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(0, 2)]
        [TestCase(2, 0)]
        public void CheckPlace_empty_table(int x, int y)
        {
            string[,] testArray =
            {
                {" ", " ", " "},
                {" ", " ", " "},
                {" ", " ", " "}
            };
            
            comp = new Computer(x, y);
            
            Assert.IsTrue(comp.CheckPlace(testArray));
        }
        
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(0, 2)]
        [TestCase(2, 0)]
        public void CheckPlace_taken_places(int x, int y)
        {
            string[,] testArray =
            {
                {"X", "X", "X"},
                {"X", "X", "X"},
                {"X", "X", "X"}
            };
            
            comp = new Computer(x, y);
            
            Assert.IsFalse(comp.CheckPlace(testArray));
        }
    }

    [TestFixture]
    public class CalculateMoveTests
    {
        private Computer comp1;
        private Computer comp2;

        private static bool CompareComputers(Computer c1, Computer c2)
        {
            if (c1.X == c2.X && c1.Y == c2.Y)
            {
                return true;
            }

            return false;
        }
        
        [Test]
        public void CalculateMove_taken_place()
        {
            comp1 = new Computer(0, 0);
            comp2 = new Computer(0, 1);
            string[,] testArray =
            {
                {" ", " ", " "},
                {" ", " ", " "},
                {" ", " ", " "}
            };

            testArray[0, 0] = "X";
            
            Assert.IsTrue(CompareComputers(comp2, comp1.CalculateMove(testArray)));
        }
        
        [Test]
        public void CalculateMove_free_place()
        {
            comp1 = new Computer(0, 0);
            comp2 = new Computer(0, 0);
            string[,] testArray =
            {
                {" ", " ", " "},
                {" ", " ", " "},
                {" ", " ", " "}
            };
            
            Assert.IsTrue(CompareComputers(comp2, comp1.CalculateMove(testArray)));
        }
    }
}