using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch {
    [TestClass]
    public class UnitTest2 {
        [TestMethod]
        public void CheckForFactorsOfABigNumber() {
            CollectionAssert.AreEqual(new int[] { 2, 2, 3, 3, 5, 7, 7 }, FindAllFactors(8820));
        }

        [TestMethod]
        public void LCM_OF_4_10() {
            Assert.AreEqual(20, LCM(4,10));
        }

        [TestMethod]
        public void LCM_OF_10_4() {
            Assert.AreEqual(20, LCM(10, 4));
        }

        [TestMethod]
        public void LCM_OF_4_6() {
            Assert.AreEqual(12, LCM(4, 6));
        }

        [TestMethod]
        public void LCM_OF_6_4() {
            Assert.AreEqual(12, LCM(6, 4));
        }

        [TestMethod]
        public void PrimeFactorsOf4() {
            CollectionAssert.AreEqual(new int[] { 2, 2 }, FindAllFactors(4));
        }

        [TestMethod]
        public void FactorsOf10() {
            CollectionAssert.AreEqual(new int[] { 2, 5 }, FindAllFactors(10));
        }

        [TestMethod]
        public void FactorsOf6() {
            CollectionAssert.AreEqual(new int[] { 2, 3 }, FindAllFactors(6));
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

        public int FindPower(int[] primefactors, int powercandidate){
            int powercount = 0;
            for (int i = 0; i < primefactors.Length; i++) {
                if (primefactors[i] == powercandidate) powercount++;
            }
            return powercount;
        }

        public int CalculateLimitOfArray(int[,] array, int lastknownlimitofarray){
            int limitofarray = 0;
            for (int i = 0; i < lastknownlimitofarray; i++) {
                if (array[i, 0] != 0) limitofarray++;
                if (array[i, 0] == 0) break;
            }
            return limitofarray;
        }

        public int[,] TrimTheArrayOfZeros(int[,] arraytotrim, int newarraylimit) {
            int[,] trimmedarray = new int[newarraylimit, 2];
            for (int i = 0; i < newarraylimit; i++) {
                trimmedarray[i, 0] = arraytotrim[i, 0];
                trimmedarray[i, 1] = arraytotrim[i, 1];
            }
            return trimmedarray;
        }

        public int[,] PowerOfFactors(int a) {
            int[] primefactorsofnumber = FindAllFactors(a);
            int nextfactor = 0;
            int[,] powerfactors = new int[primefactorsofnumber.Length, 2];
            int lenght = primefactorsofnumber.Length;
            for (int i = 0; i < primefactorsofnumber.Length; i++) {
                if (nextfactor >= primefactorsofnumber.Length) break;
                powerfactors[i, 0] = primefactorsofnumber[nextfactor];
                powerfactors[i, 1] = FindPower(primefactorsofnumber, powerfactors[i, 0]);
                nextfactor += powerfactors[i, 1];
            }
            int limitofarray = CalculateLimitOfArray(powerfactors, lenght);

            int[,] finalarray = new int[limitofarray + 1, 2];
            finalarray = TrimTheArrayOfZeros(powerfactors, limitofarray);
            return finalarray;
        }

        public int[,] CheckForOccurances(int [,] arraytocheck, int occurance){
            int[,] pair = new int [1,2]{{0,0}};
            int length = arraytocheck.GetLength(0);
            for (int i = 0; i < length; i++) {
                if (arraytocheck[i, 0] == occurance) {
                    pair[0, 0] = arraytocheck[i, 0];
                    pair[0, 1] = arraytocheck[i, 1];
                }
            }
            return pair;
        }

        public double CalculateLCM(int[,] array2, int[,] array1) {
            int[,] zero = new int[1, 2] { { 0, 0 } };
            int[,] temp = new int[1, 2];
            int power;
            int lenghtprimefactorsofnumber1 = array1.GetLength(0);
            int lenghtprimefactorsofnumber2 = array2.GetLength(0);
            double lcm = 1;
            for (int i = 0; i < lenghtprimefactorsofnumber2; i++) {
                if (i != lenghtprimefactorsofnumber1) {
                    temp = CheckForOccurances(array2, array1[i, 0]);
                    if (temp == zero) lcm = lcm * Math.Pow(array1[i, 0], array1[i, 1]);
                    if (temp != zero) {
                        power = Math.Max(array1[i, 1], temp[0, 1]);
                        lcm = lcm * Math.Pow(array1[i, 0], power);
                    }
                } else {
                    lcm = lcm * Math.Pow(array2[i, 0], array2[i, 1]);
                }
            }
            return lcm;
        }

        public double LCM(int number1, int number2) {
            int[,] primefactorsofnumber1 = PowerOfFactors(number1);
            int[,] primefactorsofnumber2 = PowerOfFactors(number2);
            double lcm =1; 
            int lenghtprimefactorsofnumber1 = primefactorsofnumber1.GetLength(0);
            int lenghtprimefactorsofnumber2 = primefactorsofnumber2.GetLength(0);
            if (lenghtprimefactorsofnumber2 > lenghtprimefactorsofnumber1) lcm = CalculateLCM(primefactorsofnumber2, primefactorsofnumber1);
            else lcm = CalculateLCM(primefactorsofnumber1, primefactorsofnumber2);
            return lcm;
        }      
    }
}
