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
            double ab = Math.Sqrt(Math.Pow(ac,2) + Math.Pow(bc,2));
            return ab;
        }

        public double SemiperimiterOfATriangle(double a, double b, double c) {
            double p = (a + b + c) / 2;
            return p;
        }

        public double TriangleAreaWithHeron(double a, double b, double c, double p) {
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public double CalculateArea(double x1, double y1, double x2, double y2, double x3, double y3) {
            double width1, width2, width3;
            double lenght1, lenght2, lenght3;
            double semiper;
            double hypotenuse1, hypotenuse2, hypotenuse3;

            width1 = DistanceBetweenTwoCoordinates(y1, y2);
            width2 = DistanceBetweenTwoCoordinates(y1, y3);
            width3 = DistanceBetweenTwoCoordinates(y2, y3);

            lenght1 = DistanceBetweenTwoCoordinates(x1, x2);
            lenght2 = DistanceBetweenTwoCoordinates(x1, x3);
            lenght3 = DistanceBetweenTwoCoordinates(x2, x3);

            hypotenuse1 = Pythagoras(width1, lenght1);
            hypotenuse2 = Pythagoras(width2, lenght2);
            hypotenuse3 = Pythagoras(width3, lenght3);

            semiper = SemiperimiterOfATriangle(hypotenuse1, hypotenuse2, hypotenuse3);

            return TriangleAreaWithHeron(hypotenuse1, hypotenuse2, hypotenuse3, semiper);
            
        }

    }
}
