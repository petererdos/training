using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking {
    [TestClass]
    public class UnitTest1 {

        double suma = 40000;
        double dobanda = 7.57;
        double aniperioada = 20;
        int lunaceruta = 16;
        
        [TestMethod]
        public void PercentsOfRequestedMonth() {
            Assert.AreEqual(10, CalculateMonthlyPercent());
        }

        public double CalculateMonthlyPercent() {
            double months = aniperioada * 12;
            double[] percents = new double[(int)months];
            for (int i = 1; i <= (int)months; i++) {
                double monthlypercent = 100 - (100-(((int)months-(i-1))*100)/100);
                //percents[i] = monthlypercent;
                }
            return (int)months;
        }

    }
}
