using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms {
    [TestClass]
    public class Mushrooms {
        int mushrooms = 12;
        int x = 2;
        [TestMethod]
        public void VerifyNumberOfAllMushrooms() {
            Assert.IsTrue(NumberOfAllMushrooms());
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

        public bool NumberOfAllMushrooms() {
            if (mushrooms % (x + 1) == 0) {
                return true;
            } else {
                return false;
            }
        }

    }
}
