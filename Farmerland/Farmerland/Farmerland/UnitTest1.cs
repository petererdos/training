using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmerland {
    [TestClass]
    public class Farmerland {
        [TestMethod]
        public void SearchForTheValueOfA() {
            Assert.AreEqual(770, CalculateArea(230, 770000));
        }

        [TestMethod]
        public void ValueFound() {
            Assert.AreNotEqual(0, CheckIfValueWasFound(230, 770000));
        }

        public int CalculateArea(int b, int area) {
            for (int i = 1; i < area; i++) {
                int a = i * (i + b);
                if (a == area) return i;
            }
            return 0;
        }

        public int CheckIfValueWasFound(int b, int area) {
            int valuewasfound = CalculateArea(b, area);
            return valuewasfound;
        }

    }
}
