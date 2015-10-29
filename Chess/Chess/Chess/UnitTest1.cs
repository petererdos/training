using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalNumberOfSquares()
        {
            Assert.AreEqual(204, CalculateChessBoard());
        }

        public int CalculateChessBoard()
        {
            int squares = 0;
            for (int i=1; i<=8; i++)
            {
                squares = squares + (i * i);
            }
            return squares;
        }

    }
}
