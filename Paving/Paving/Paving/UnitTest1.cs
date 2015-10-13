using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Paving {
    [TestClass]
    public class Paving {

        [TestMethod]
        public void CheckTotalNumberOfTilesNeeded() {
            Assert.AreEqual(4, CalculateTiles(6, 6, 4));
        }

        [TestMethod]
        public void CheckNumberOfTilesPerWidth() {
            Assert.AreEqual(2, CalculateMA(6, 4));
        }

        [TestMethod]
        public void CheckNumberOfTilesPerLenght() {
            Assert.AreEqual(2, CalculateNA(6, 4));
        }

        public double CalculateMA(double m, double a) {
            double ma = Math.Ceiling(m / a);
            return ma;
        }

        public double CalculateNA(double n, double a) {
            double na = Math.Ceiling(n / a);
            return na;
        }

        public double CalculateTiles(double m, double n, double a) {
            double tiles = CalculateMA(m, a) * CalculateNA(n, a);
            return tiles;
        }

    }
}
