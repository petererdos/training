using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encryption
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckNewString()
        {
            Assert.AreEqual("test", Encrypt(4,"nicaieri, nu e ca acasa"));
        }
        /*
        [TestMethod]
        public void CheckNewString()
        {
            Assert.AreEqual("test", StripString("nicaieri, nu e ca acasa"));
        }

        [TestMethod]
        public void CheckLines()
        {
            Assert.AreEqual(1, CalculateLines(4,"nicaieri, nu e ca acasa"));
        }

        [TestMethod]
        public void CheckCharNums()
        {
            Assert.AreEqual(1, CountChars("nicaieri, nu e ca acasa"));
        }
        */

        public string StripString(string str)
        {
            StringBuilder newstring = new StringBuilder();
            foreach (char c in str)
            {
                if (Char.IsLetter(c)) {
                    newstring.Append(c);
                    }
            }
            string result = newstring.ToString();
            return result;
        }

        public int CountChars(string str) {
            int i = 0;
            string newstring = StripString(str);
            foreach (char c in newstring) i++;
            return i;
        }

        public int CalculateLines(int columns, string str)
        {
            int count = CountChars(str);
            double linenumbers = (float)count / (float)columns;
            double lines = Math.Ceiling(linenumbers);
            return (int)lines;

        }

        static Random rnd = new Random();
        public static char GetLetter()
        {
            int num = rnd.Next(0, 26);
            char let = (char)('a' + num);
            return let;
        }


        public string Encrypt(int columns, string str)
        {
            string newstring = StripString(str);
            int charnumber = CountChars(newstring);
            int lines = CalculateLines(columns, newstring);
            int togenerate = (lines * columns) - charnumber;
            StringBuilder genstring = new StringBuilder();

            for (int i = 1; i <= togenerate; i++)
            {
                genstring.Append(GetLetter());
            }
            string appendstring = genstring.ToString();
            string finalstring = newstring + appendstring;
            string[,] enc = new string[lines,columns];


            return finalstring;
        } 

    }
}
