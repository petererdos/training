using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void VerifyMelon() {
            Assert.IsTrue(CheckIfMelonCanBeSplittedInTwoEvenNumberParts(10));
        }

        public bool CheckIfMelonCanBeSplittedInTwoEvenNumberParts(int kg) {
            bool result = false;
            if (kg % 2 == 0) {
                if ((kg / 2) % 2 == 0) {
                    result = true;
                }
                if (((kg / 2) - 1) % 2 == 0) {
                    if (((kg / 2) + 1) % 2 == 0) {
                        result = true;
                    }
                }
            }
            return result;
        }

    }
}
