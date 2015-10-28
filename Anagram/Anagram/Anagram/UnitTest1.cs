using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Anagram {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void AnagramsOfEmptyString() {
            Assert.AreEqual(-1, CalculateAnagrams(""));
        }

        [TestMethod]
        public void AnagramsOfInvalidString1() {
            Assert.AreEqual(-1, CalculateAnagrams("Invalid String"));
        }

        [TestMethod]
        public void AnagramsOfInvalidString2() {
            Assert.AreEqual(-1, CalculateAnagrams("Invalid-String"));
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

        [TestMethod]
        public void AnagramsOfWord_MMAAAATH() {
            Assert.AreEqual(840, CalculateAnagrams("mmaaaath"));
        }

        [TestMethod]
        public void AnagramsOfWord_AABB() {
            Assert.AreEqual(6, CalculateAnagrams("aabb"));
        }

        public static bool AreAllLetters(string s) {
            foreach (char c in s) {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public int CountDivisors(List<char> theword, char c) {
            int count=0;
            for (int i=0; i<theword.Count;i++){
                if (theword[i] == c) count++;
            }
            return count;
        }

        public List<char> DeleteProcessedChar(List<char> theword, char c) {
            int lenght = theword.Count;
            for (int i = 0; i < lenght; i++) {
                if (theword[i] == c) {
                    theword.Remove(c);
                    i--;
                    lenght--;
                }
            }
            return theword;
        }

        public List<char> ConvertToList(string word) {
            List<char> theword = new List<char>();
            foreach (char c in word){
                theword.Add(c);
            }
            return theword;
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
            if (AreAllLetters(word) == false) return -1;
            int anagrams = Factorial(letters);
            List<char> theword = new List<char>();
            theword = ConvertToList(word);


            do {
                char c = theword[0];
                int occurance = CountDivisors(theword, c);
                anagrams = anagrams / Factorial(occurance);
                theword = DeleteProcessedChar(theword, c);
            } while (theword.Count != 0);
         
            return anagrams;
        }
    }
}