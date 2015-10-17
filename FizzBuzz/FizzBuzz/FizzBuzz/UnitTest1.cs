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


        public string FizzBuzzChecker(int number)
        {
            string result = "None";
            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                {
                    result = "FizzBuzz";
                    return result;
                }
            }
            if (number % 3 == 0)
            {
                result = "Fizz";
                return result;
            }
            if (number % 5 == 0)
            {
                result = "Buzz";
                return result;
            }
            return result;
        }
    }
}
