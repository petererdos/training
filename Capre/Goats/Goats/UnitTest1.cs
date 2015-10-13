using System;
using System.Diagnostics;
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

        /* Wanted to add a relation between the alphabetic naming,
         * like A < B < C, but with the possibility to customize the unit.
         * So if the unit is 1, A=1, B=2, C=3 and so on; this is the reasoning behind forcing to 
         * pass the tests only if the values of the goats, days and kg have this
         * relation.
         */

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

        [TestMethod]
        public void CheckOneGoatOneDay() {
            Assert.AreEqual(0.04, CalculateOneGoatOneDay());
        }

        [TestMethod]
        public void CheckResults() {
            Assert.AreEqual(15.64, CalculateQGoatsFood());
        }


        public double CalculateOneGoatOneDay() {
            double xgoatsoneday = zKg / xDays;
            double onegoatonedaydec = xgoatsoneday / yGoats;
            double onegoatoneday = Math.Round(onegoatonedaydec, 2, MidpointRounding.AwayFromZero);
            return onegoatoneday;
        }

        public double CalculateQGoatsFood() {
            double qgoatsfooddec = CalculateOneGoatOneDay() * wDays * qGoats;
            double qgoatsfood = Math.Round(qgoatsfooddec, 2, MidpointRounding.AwayFromZero);
            return qgoatsfood;
        }
    }
}
