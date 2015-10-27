using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert1208()
        {
            CollectionAssert.AreEqual(new string[] { "A", "T", "L" }, ConvertToBase(1208, 26));
        }

        [TestMethod]
        public void Convert2159() {
            CollectionAssert.AreEqual(new string[] { "C", "E", "A" }, ConvertToBase(2159, 26));
        }

        [TestMethod]
        public void Convert159() {
            CollectionAssert.AreEqual(new string[] { "F", "C" }, ConvertToBase(159, 26));
        }

        [TestMethod]
        public void Convert59() {
            CollectionAssert.AreEqual(new string[] { "B", "G" }, ConvertToBase(59, 26));
        }

        [TestMethod]
        public void Convert1() {
            CollectionAssert.AreEqual(new string[] { "A" }, ConvertToBase(1, 26));
        }

        [TestMethod]
        public void Convert2() {
            CollectionAssert.AreEqual(new string[] { "B" }, ConvertToBase(2, 26));
        }

        [TestMethod]
        public void Convert27() {
            CollectionAssert.AreEqual(new string[] { "A", "A" }, ConvertToBase(27, 26));
        }

        [TestMethod]
        public void Convert0_InvalidNumber() {
            CollectionAssert.AreEqual(new string[] { "0" }, ConvertToBase(0, 26));
        }




        public int[] ExecuteDivisions(int number, int thebase) {
            int[] remainder = new int[thebase];
            int[] division = new int[thebase];
            division[0] = number;
            int i = 1;
            do {
                division[i] = division[i-1] / thebase;
                remainder[i-1] = division[i-1]-division[i]*thebase;
                i++;
            } while (division[i-1] > thebase);
            remainder[i-1] = division[i-1];
            return remainder;
        }

        public int CountNonZeroMembers(int[] array) {
            int count=0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] != 0) count++;
                else break;
            }
            return count;
        }


        public int[] CleanUpArrayOfZeros(int[] array) {
            int lenght=CountNonZeroMembers(array);
            int[] cleanarray= new int[lenght];
            for (int i = 0; i < lenght; i++) {
                cleanarray[i] = array[i];
            }
            return cleanarray;
        }

        public int[] InvertTheArray(int[] array) {
            int count=0;
            int[] invertedarray = new int[array.Length];
            for (int i = array.Length; i > 0; i--) {
                invertedarray[count] = array[i - 1];
                count++;
            }
            return invertedarray;
        }

        public string[] ConvertBase(int[] array) {
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int length = array.Length;
            string[] converted = new string[length];
            for (int i = 0; i < length; i++) {
                converted[i]=alphabet[array[i]-1];
            }
            return converted;
        }

        public string[] ConvertToBase(int number, int thebase) {

            string[] invalidnumber = new string[1]{"0"};
            if (number < 1) return invalidnumber;

            int[] remainders = InvertTheArray(CleanUpArrayOfZeros(ExecuteDivisions(number, thebase)));
            string[] converted = ConvertBase(remainders);
            return converted;            
        }

    }
}
