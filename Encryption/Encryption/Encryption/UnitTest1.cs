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
            //This will always fail because of the randomly generated characters
            Assert.AreEqual("test", Encrypt(4,"nicaieri, nu e ca acasa"));
        }
        /*

        [TestMethod]
        public void CheckIfStringIsNull()
        {
            Assert.AreEqual(null, CheckNull("nicaieri, nu e ca acasa"));
        }

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
            //keep only letters
            string newstring = StripString(str);
            //count the number of characters in the stripped string
            int charnumber = CountChars(newstring);
            //calculate the limits of the array which will be used for the encryption
            int lines = CalculateLines(columns, newstring);

            //how many characters to generate?
            int togenerate = (lines * columns) - charnumber;
            StringBuilder genstring = new StringBuilder();
            for (int i = 1; i <= togenerate; i++)
            {
                genstring.Append(GetLetter());
            }
            string appendstring = genstring.ToString();
            string finalstring = newstring + appendstring;

            //build the 2D array for encryption
            char[,] enc = new char[columns,lines];
            int x = 0;
            int y = 0;
            foreach (char c in finalstring)
            {

                enc[x, y] = c;

                if (x==(columns-1))
                    if (y == (lines - 1)) break;         
                            
                if (y == (lines-1))
                {
                    y = -1;
                    x++;
                }
                y++;
            }

            //rebuild the encrypted string from the array
            StringBuilder encstring = new StringBuilder();
            x = 0;
            y = 0;
            int charnumfinalstring = CountChars(finalstring);
            for (int i=0; i < charnumfinalstring; i++)
            {
                encstring.Append(enc[x, y]);

                if (x == (columns - 1))
                    if (y == (lines - 1)) break;               

                if (x == (columns - 1))
                {
                    x = -1;
                    y++;
                }
                x++;
            }
            string finalencstring = encstring.ToString();

            return finalencstring;
        } 

    }
}