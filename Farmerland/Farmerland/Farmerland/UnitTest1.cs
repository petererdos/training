using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmerland {
    [TestClass]
    public class Farmerland {
        [TestMethod]
        public void GuessTheValueOfA() {
            Assert.AreEqual(770, CalculateArea());
        }

        public int CalculateArea() {
            for (int i = 1; i < 770000; i++) {
                int a = i * (i + 230);
                if (a == 770000) return i;
            }
            return 0;
        }
    }
}
