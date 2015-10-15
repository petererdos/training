using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parquet {
    [TestClass]
    public class Parquet {
        [TestMethod]
        public void CheckParquetPieces() {
            Assert.AreEqual(149, CalculatePieces(5, 7, 1.380, 0.195),1);
        }

        public double CalculatePieces(double a, double b, double m, double n) {
            double roomarea = a * b;
            double parquetarea = m * n;
            double areadifference = roomarea / parquetarea;
            double totalparquetpieces = areadifference + (areadifference * 0.15);
            return totalparquetpieces;
        }
    }
}
