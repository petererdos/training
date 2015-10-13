using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms {
    [TestClass]
    public class Mushrooms {
        int mushrooms = 12;
        int x = 2;
        [TestMethod]
        public void NumberOfAllMushrooms() {
            if (mushrooms % (x+1) == 0) {
                Assert.AreEqual(mushrooms, CheckNumberOfAllMushrooms());
            } else {
                Assert.Fail("Total number of mushrooms invalid!");
            }
        }
        [TestMethod]
        public void CheckNumberOfRedMushhrooms() {
            Assert.AreEqual(8, NumberOfRedMushrooms());
        }

        public int NumberOfRedMushrooms() {
            int white = mushrooms / (x + 1);
            int red = white * 2;
            return red;
        }

        public int CheckNumberOfAllMushrooms() {
            int white = mushrooms / (x+1);
            int red = white*2;
            int result = white + red;
            return result;
        }
    }
}
