using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch {
    [TestClass]
    public class UnitTest2 {
        [TestMethod]
        public void CheckForFactorsOfANumber() {
            CollectionAssert.AreEqual(new int[] {2, 3, 3, 5}, FindAllFactors(90));
        }

        public bool IsPrime(int number) {
            bool isprime = true;
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i < number; i++) {
                if (number % i == 0) return false;
            }
            return isprime;
        }

        public bool IsItFactor(int number, int factorcandidate) {
            bool isitfactor = false;
                if (IsPrime(factorcandidate) == true && number % factorcandidate == 0) isitfactor=true;              
            return isitfactor;
        }

        public int CheckIfAllPrimeFactorsAreFound(int[] primefactors, int numberoffactorsfound) {
            int productofallnumbers = 1;
            for (int i = 0; i < numberoffactorsfound; i++) {
                productofallnumbers = productofallnumbers * primefactors[i];
            }
            return productofallnumbers;
        }

        public int[] FindAllFactors(int number) {
            int[] factors = new int[number];
            int countfactors=0;
            int partialnumber=number;
            bool arethereanyfactors = false;
            int divider = 2;
            int productoffactors = 0;
            if (number > 1) {
                do {
                    if (IsItFactor(partialnumber, divider) == true) {
                        partialnumber = partialnumber / divider;
                        factors[countfactors] = divider;
                        countfactors++;
                        if (divider != number) arethereanyfactors = true;
                        divider = 1;
                        productoffactors = CheckIfAllPrimeFactorsAreFound(factors, countfactors);
                    }
                    divider++;
                } while (productoffactors != number);

                if (arethereanyfactors == false) {
                    Array.Resize(ref factors, 2);
                    factors[0] = 1;
                    factors[1] = number;
                    return factors;
                }

                Array.Resize(ref factors, countfactors);
            }
            return factors;
        } 

    }
}
