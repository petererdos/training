using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sports {
    [TestClass]
    public class Sports {
        [TestMethod]
        public void CheckTheNumberOfPracticeSessions() {
            Assert.AreEqual(49, CaculatePracticeSessions(7));
        }

        public int CaculatePracticeSessions(int n) {
            int totalrounds = 0;
            for (int i = 1; i <= n; i++) {
                totalrounds = totalrounds + i;
            }
            totalrounds = 2 * totalrounds - n;
            return totalrounds;
        }
    }
}