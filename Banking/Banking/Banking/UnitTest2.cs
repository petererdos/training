using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking {
    [TestClass]
    public class UnitTest2 {
        [TestMethod]
        public void CheckMonthlyRate() {
            Assert.AreEqual(388.5, (CalculatePrincipal(40000, 20)+CalculateInterest(40000, 20, 38, 7.87)), 0.5);
        }

        [TestMethod]
        public void CheckPrincipal() {
            Assert.AreEqual(166, CalculatePrincipal(40000, 20), 0.9);
        }

        [TestMethod]
        public void CheckInterest() {
            Assert.AreEqual(220.5, CalculateInterest(40000, 20, 39, 7.87), 0.9);
        }

        public double CalculatePrincipal(int credit, int years) {
            double principal = credit / (years * 12);
            return principal;
        }

        public double CalculateInterest(int credit, int years, int month, double interest) {
            double monthlyinterest = interest / 12;
            double monthlyrateinterest = (((credit -((month-1)*CalculatePrincipal(credit, years))) * monthlyinterest) / 100);
            return monthlyrateinterest;
        }

    }
}
