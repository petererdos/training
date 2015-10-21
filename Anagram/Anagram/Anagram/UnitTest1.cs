using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
        }
    }

    public int Factorial(int n){
        int factorial=1;
        for (int i=2; i<=n; i++) {
            factorial=factorial*i;
        }
        return factorial;
    }

    public int CalculateAnagrams(string word) {

    }
}
