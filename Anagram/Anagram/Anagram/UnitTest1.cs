using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void AnagramsOfEmptyString() {
            Assert.AreEqual(-1, CalculateAnagrams(""));
        }


        [TestMethod]
        public void AnagramsOfWord_A() {
            Assert.AreEqual(1, CalculateAnagrams("A"));
        }

        [TestMethod]
        public void AnagramsOfWord_IS() {
            Assert.AreEqual(2, CalculateAnagrams("is"));
        }

        [TestMethod]
        public void AnagramsOfWord_ONE() {
            Assert.AreEqual(6, CalculateAnagrams("one"));
        }

        [TestMethod]
        public void AnagramsOfWord_MATH() {
            Assert.AreEqual(24, CalculateAnagrams("math"));
        }


        public int Factorial(int n) {
            int factorial = 1;
            for (int i = 2; i <= n; i++) {
                factorial = factorial * i;
            }
            return factorial;
        }

        public int CalculateAnagrams(string word) {
            int letters = word.Length;
            if (letters < 1) return -1;
            int anagrams = Factorial(letters);
            return anagrams;
        }
    }
}