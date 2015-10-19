using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _888 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void CheckTrippleEightValidNumber1() {
            Assert.AreEqual(192,TrippleEight(1));
        }

        [TestMethod]
        public void CheckTrippleEightValidNumber2() {
            Assert.AreEqual(442, TrippleEight(2));
        }

        [TestMethod]
        public void CheckTrippleEightInvalidNumber() {
            Assert.AreEqual(0, TrippleEight(0));
        }

        public double TrippleEight(int k)
        {
            int nth=0;
            double number=1;
            double value=1;
            double toreturn=0;
            if (k > 0) {
                do {
                    value = Math.Pow(number, 3);
                    if (value % 1000 == 888) {
                        nth++;
                        toreturn = number;
                    }
                    number++;
                } while (nth != k);
                return toreturn;
            }
            return 0;
        }

    }
}
