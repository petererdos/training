using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking {
    [TestClass]
    public class UnitTest1 {

        /*double suma = 40000;
        double dobanda = 7.57;
        double aniperioada = 20;
        int lunaceruta = 23;*/
        
        [TestMethod]
        public void PercentsOfRequestedMonth() {
            Assert.AreEqual(378.77, CalculateMonthlyPercent(40000, 20, 7.57, 39));
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

    }
}
