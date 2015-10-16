using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmerland {
    [TestClass]
    public class Farmerland2 {
        [TestMethod]
        public void VerifyHeight() {
            Assert.AreEqual(770, CalculateHeight(230, 770000));
        }

        [TestMethod]
        public void VerifyDelta() {
            Assert.AreEqual(3132900, CalculateDelta(230, 770000));
        }

        [TestMethod]
        public void VerifyInitialArea() {
            Assert.AreEqual(592900, CalculateInitialArea(230, 770000));
        }

        public int CalculateDelta(int width, int area) {
            
            int b = width;
            int c = -area;
            int delta = b * b - 4 * c;
            if (delta>0) return delta;
            return 0;
        }

        public double CalculateHeight(int width, int area) {
            int b = width;
            int c = -area;
            double height = ((-b) + Math.Sqrt(CalculateDelta(width, area))) / 2;
            return Math.Abs(height);
        }

        public double CalculateInitialArea(int width, int area) {
            double initialarea = Math.Pow(CalculateHeight(width, area), 2);
            return initialarea;
        }

    }
}
