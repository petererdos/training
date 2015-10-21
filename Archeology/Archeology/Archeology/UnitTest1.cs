using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archeology {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void VerifyAreaOfATriagle() {
            Assert.AreEqual(6, CalculateArea(1, 1, 1, 5, 4, 5));
        }

        [TestMethod]
        public void VerifyAreaOfAnotherTriagle1() {
            Assert.AreEqual(9, CalculateArea(1.123456, 3.123456, 5.123456, 5.123456, 4.123456, 0.123456),1);
        }

        [TestMethod]
        public void VerifyAreaOfMirroredTriagle1() {
            Assert.AreEqual(9, CalculateArea(5.123456, 5.123456, 1.123456, 3.123456, 4.123456, 0.123456),1);
        }


        public double DistanceBetweenTwoCoordinates(double c1, double c2) {
            return Math.Abs(c1 - c2);
        }

        public double Pythagoras(double ac, double bc) {
            return Math.Sqrt(Math.Pow(ac,2) + Math.Pow(bc,2));
        }

        public double SemiperimiterOfATriangle(double a, double b, double c) {
            return (a + b + c) / 2;
        }

        public double TriangleAreaWithHeron(double a, double b, double c) {
            var p = SemiperimiterOfATriangle(a, b, c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double CalculateArea(double x1, double y1, double x2, double y2, double x3, double y3) {
            var firstSide = CalculateDistance(x1, y1, x2, y2);
            var secondSide = CalculateDistance(x1, y1, x3, y3);
            var thirdSide = CalculateDistance(x2, y2, x3, y3);
                        
            return TriangleAreaWithHeron(firstSide, secondSide, thirdSide);
        }

        private double CalculateDistance(double x1, double y1, double x2, double y2) {
            var width = DistanceBetweenTwoCoordinates(y1, y2);
            var length = DistanceBetweenTwoCoordinates(x1, x2);
            return Pythagoras(width, length);
        }

    }
}
