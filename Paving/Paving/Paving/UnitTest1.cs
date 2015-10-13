using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Paving {
    [TestClass]
    public class Paving {
        double m = 6;
        double n = 6;
        double a = 4;

        [TestMethod]
        public void CheckTotalNumberOfTilesNeeded() {
            Assert.AreEqual(4, CalculateTiles());
        }

        [TestMethod]
        public void CheckNumberOfTilesPerWidth() {
            Assert.AreEqual(2, CalculateMA());
        }

        [TestMethod]
        public void CheckNumberOfTilesPerLenght() {
            Assert.AreEqual(2, CalculateNA());
        }

        public double CalculateMA() {
            double ma = Math.Ceiling(m / a);
            return ma;
        }

        public double CalculateNA() {
            double na = Math.Ceiling(n / a);
            return na;
        }

        public double CalculateTiles() {
            double tiles = CalculateMA() * CalculateNA();
            return tiles;
        }

    }
}
