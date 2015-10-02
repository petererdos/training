using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainsAndBirds {
    [TestClass]
    public class TrainsAndBirds {
        float dt = 9;
        [TestMethod]
        public void CheckSpeedOfBothTrains() {
            Assert.AreEqual(dt / 2, BirdDistance());
        }

        /*[TestMethod]
        public void CheckIfDistanceIsAnEvenInteger() {
            Assert.IsTrue(IsEvenInteger());
        }

        public bool IsEvenInteger() {
            if (dt == (int)dt) {
                if (dt % 2 == 0) {
                    return true;
                } else return false; 
            } else return false;            
        } */

        public float BirdDistance() {
            float db = dt-(dt/4)-(dt/4);
            Debug.WriteLine("Distanta pasare: " + db); 
            return db;
        }
    }

}
