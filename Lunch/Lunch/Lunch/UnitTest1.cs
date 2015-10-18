using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class UnitTest1
    {

        // You will meet with your friend the second time:
        // -|||-|||-|||-    <- friend
        // -|||||-|||||-    <- you
        // On day one you meet by default

        [TestMethod]
        public void YouWillMeetWithYourFriendOnYourNthLunch()
        {
            Assert.AreEqual(3, CalculateLunchDate("yournthlunch"));
        }

        [TestMethod]
        public void YourFriendWillMeetYouOnHisNthLunch()
        {
            Assert.AreEqual(4, CalculateLunchDate("hisnthlunch"));
        }

        [TestMethod]
        public void YouBothMeetOnDay()
        {
            Assert.AreEqual(13, CalculateLunchDate("nthday"));
        }

        public int CalculateLunchDate(string whichdata)
        {
            int friendnthlunch = 1;
            int yournthlunch = 1;
            int hismeetingday = -1;
            int yourmeetingday = -2;
            int friend = 4;
            int you = 6;
            int day = 1; 
            do
            {
                day++;
                if (day % friend == 0)
                {
                    friendnthlunch++;
                    hismeetingday = day+1;
                }

                if (day % you == 0)
                {
                    yournthlunch++;
                    yourmeetingday = day+1;
                }

            } while (hismeetingday != yourmeetingday);

            if (whichdata == "yournthlunch") return yournthlunch;
            if (whichdata == "hisnthlunch") return friendnthlunch;
            if (whichdata == "nthday") return day+1;
            return 0;
        }
    }
}
