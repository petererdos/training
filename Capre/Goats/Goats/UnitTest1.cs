using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats {
    [TestClass]
    public class GoatsFood {
        int xDays = 24;
        int yGoats = 25;
        int zKg = 26;
        int qGoats = 17;
        int wDays = 23;
        int unit = 1;

        [TestMethod]
        public void CheckXDaysValue() {
            Assert.AreEqual(yGoats, 25 * unit);
        }

        [TestMethod]
        public void CheckYGoatsValue() {
            Assert.AreEqual(yGoats, 25 *unit);
        }

        [TestMethod]
        public void CheckZKgValue() {
            Assert.AreEqual(zKg, 26 * unit);
        }

        [TestMethod]
        public void CheckWDaysValue() {
            Assert.AreEqual(wDays, 23 * unit);
        }

        [TestMethod]
        public void CheckQGoatsValue() {
            Assert.AreEqual(qGoats, 17 * unit);
        }


        /*public int Goats() {



            
        }*/
    }
}
