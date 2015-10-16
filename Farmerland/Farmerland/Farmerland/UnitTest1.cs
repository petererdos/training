using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmerland {
    [TestClass]
    public class Farmerland {
        [TestMethod]
        public void GuessTheValueOfA() {
            Assert.AreEqual(770, CalculateArea(770000));
        }

        public int CalculateArea(int area) {
            for (int i = 1; i < area; i++) {
                int a = i * (i + 230);
                if (a == 770000) return i;
            }
            return 0;
        }
    }
}
