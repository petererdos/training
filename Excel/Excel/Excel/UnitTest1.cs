using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RemainderCount()
        {
            Assert.AreEqual(1,CountDivisions(4520,26));
        }

        public int Divide(int number, int thebase){
            int quotient = number/thebase;
            return quotient;
        }

        public int GetRemainder(int number, int thebase) {
            int remainder=number-(number/thebase);
            return remainder;
        }

        public int CountDivisions(int number, int thebase) {
            int count = 0;
            while (GetRemainder(number, thebase)>thebase) {
                number = number / thebase;
                count++;
            }
            return count;
        }

        public int[] BaseConverter(int number, int thebase) {
            int divisions = CountDivisions(number, thebase);
            int[] remainders = new int[divisions];
            remainders[0] = number;
            for (int i = 0; i < divisions; i++) {
                remainders[i] = Divide(remainders[i], thebase);
            }
            return remainders;
        }



        public char ConvertToBase(int number, int thebase) {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[] converted = BaseConverter(number, thebase);

            
        }

    }
}
