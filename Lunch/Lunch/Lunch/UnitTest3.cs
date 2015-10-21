using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch {
    [TestClass]
    public class UnitTest3 {
        [TestMethod]
        public void GCDOfTwoNumbers() {
            Assert.AreEqual(12, LCM(6, 4));
        }

        [TestMethod]
        public void GCDOfInvalidNumbers1() {
            Assert.AreEqual(-1, LCM(0, 4));
        }

        [TestMethod]
        public void GCDOfInvalidNumbers2() {
            Assert.AreEqual(-1, LCM(4, 0));
        }

        [TestMethod]
        public void GCDOfEqualNumbers() {
            Assert.AreEqual(4, LCM(4, 4));
        }

        public int GCD(int a, int b) {
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            for (int i = min; i > 0; i--) {
                if (min % i == 0 && max % i == 0)  return i;
                }
            return -1;
        }

        public int LCM(int a, int b) {
            if (a>0 && b>0) return (a * b) / GCD(a, b);
            return -1;
        }

    }
}