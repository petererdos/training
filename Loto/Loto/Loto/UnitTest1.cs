using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void _6of49() {
            Assert.AreEqual(13983816,Lottery(6,49));
        }

        [TestMethod]
        public void _5of49()
        {
            Assert.AreEqual(1906884, Lottery(5, 49));
        }

        [TestMethod]
        public void _4of49()
        {
            Assert.AreEqual(211876, Lottery(4, 49));
        }

        [TestMethod]
        public void _5of40()
        {
            Assert.AreEqual(658008, Lottery(5, 40));
        }

        public ulong Factorial(ulong n) {
            ulong factorial = 1;
            for (ulong i = 2; i <= n; i++) {
                factorial = factorial * i;
            }
            return factorial;
        }

        public int Lottery(ulong r, ulong n){
            ulong factorial = 1;
            for (ulong i = (n - r + 1); i <= n; i++)
                factorial = factorial * i;
            factorial = factorial / Factorial(r);
            return (int)factorial;
        }

    }
}
