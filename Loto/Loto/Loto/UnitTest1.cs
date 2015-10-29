using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void _6of49() {
            Assert.AreEqual(13983816,Lottery(6,49));
        }

        public ulong Factorial(ulong n) {
            ulong factorial = 1;
            for (ulong i = 2; i <= n; i++) {
                factorial = factorial * i;
            }
            return factorial;
        }

        public ulong Lottery(ulong r, ulong n){
            return Factorial(n) / (Factorial(n - r) * Factorial(r));
        }

    }
}
