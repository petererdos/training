using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void IsItFizz()
        {
            Assert.AreEqual("Fizz", FizzBuzzChecker(3));
        }

        [TestMethod]
        public void IsItBuzz()
        {
            Assert.AreEqual("Buzz", FizzBuzzChecker(5));
        }

        [TestMethod]
        public void isItFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzChecker(15));
        }

        [TestMethod]
        public void NoFizzNoBuzzAndNoFizzBuzz()
        {
            Assert.AreEqual("None", FizzBuzzChecker(2));
        }

        public bool Fizz(int number)
        {
            bool result = false;
            if (number % 3 == 0)
            {
                result = true;
            }
            return result;
        }

        public bool Buzz(int number)
        {
            bool result = false;
            if (number % 5 == 0)
            {
                result = true;
            }
            return result;
        }

        public bool FizzAndBuzz(int number)
        {
            bool result = false;
            if (Fizz(number)==true && Buzz(number) == true)
            {
                result = true;
            }
            return result;
        }

        public string FizzBuzzChecker(int number)
        {
            if (FizzAndBuzz(number) == true) return "FizzBuzz";
            if (Fizz(number) == true) return "Fizz";
            if (Buzz(number) == true) return "Buzz";
            return "None";
        }
    }
}
