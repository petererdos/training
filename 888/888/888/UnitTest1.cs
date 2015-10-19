using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _888 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void CheckTrippleEightValidNumber() {
            Assert.AreEqual(192,TrippleEight(1));
        }

        [TestMethod]
        public void CheckTrippleEightInValidNumber() {
            Assert.AreEqual(0, TrippleEight(1));
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
