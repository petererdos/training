using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch {
    [TestClass]
    public class UnitTest3 {
        [TestMethod]
        public void GCDOfTwoNumbers() {
            Assert.AreEqual(12, LCM(6, 4));
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