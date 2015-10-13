using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking {
    [TestClass]
    public class UnitTest1 {
        
        [TestMethod]
        public void MonthlyPaymentOfRequestedMonth() {
            Assert.AreEqual(378.77, CalculateMonthlyPercent(40000, 20, 7.57, 39));
        }

        [TestMethod]
        public void TotalPayed() {
            Assert.AreEqual(70199.08, CalculateTotalPayed(40000, 20, 7.57));
        }

        public double CalculateMonthlyPercent(double suma, int aniperioada, double dobanda, int lunaceruta) {
            int months = (int)aniperioada * 12;
            double capital = Math.Round((suma / months), 2, MidpointRounding.AwayFromZero);
            double dobandalunara = Math.Round((dobanda / 12), 2, MidpointRounding.AwayFromZero);
            double[] r = new double [months];
            r[1] = capital + (suma * dobandalunara) / 100;
            for (int i = 2; i < months; i++) {
                r[i] = Math.Round((capital + ((suma - (capital * (i - 1))) * dobandalunara) / 100), 2, MidpointRounding.AwayFromZero);
            }
            return r[lunaceruta];
        }

        public double CalculateTotalPayed(double suma, int aniperioada, double dobanda) {
            double total = 0;
            int months = (int)aniperioada * 12;
            double capital = Math.Round((suma / months), 2, MidpointRounding.AwayFromZero);
            double dobandalunara = Math.Round((dobanda / 12), 2, MidpointRounding.AwayFromZero);
            double[] r = new double [months];
            r[1] = capital + (suma * dobandalunara) / 100;
            for (int i = 2; i < months; i++) {
                r[i] = Math.Round((capital + ((suma - (capital * (i - 1))) * dobandalunara) / 100), 2, MidpointRounding.AwayFromZero);
            }
            for (int i=1; i < months; i++) {
                total = total + r[i];
            }
            return Math.Round(total, 2, MidpointRounding.AwayFromZero); 
        }

    }
}
