using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace TriUnitTest
{
    // Isosceles = Likbent
    // Equilateral = Liksidig
    // Scalene = Oliksidig

    [TestClass]
    public class TestSuitOne
    {
        [TestMethod]
        // Sending in a Scalene triangle and checking if triangle is Isosceles, should return False.
        public void isIsoscelesTestScaleneExpectFalse()
        {
            Triangle tri = new Triangle(3, 0.5, 6);
            Assert.IsFalse(tri.isIsosceles());
        }

        [TestMethod]
        // Sending in a Equilateral triangle and checking if triangle is Isosceles, should return False.
        public void isIsoscelesTestEquilateralExpectFalse()
        {
            Triangle tri = new Triangle(5.0, 5, 5.0);
            Assert.IsFalse(tri.isIsosceles());
        }

        [TestMethod]
        // Sending in a Isosceles triangle and checking if triangle is Isosceles, should return True.
        public void isIsoscelesTestIsoscelesExpectTrue()
        {
            Triangle tri = new Triangle(10.0, 5.0, 10.0);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        // Sending in a Scalene triangle and checking if triangle is Equilateral, should return False.
        public void isEquilateralTestScaleneExpectFalse()
        {
            Triangle tri = new Triangle(5, 6.5, 11);
            Assert.IsFalse(tri.isEquilateral());
        }

        [TestMethod]
        // Sending in a Equilateral triangle and checking if triangle is Equilateral, should return True.
        public void isEquilateralTestEquilateralExpectTrue()
        {
            Triangle tri = new Triangle(10, 10.0, 10.0);
            Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        // Sending in a Isosceles triangle and checking if triangle is Equilateral, should return False.
        public void isEquilateralTestIsoscelesExpectFalse()
        {
            Triangle tri = new Triangle(5, 10, 5.0);
            Assert.IsFalse(tri.isEquilateral());
        }

        [TestMethod]
        // Sending in a Scalene triangle and checking if triangle is Scalene, should return True.
        public void isScaleneTestScaleneExpectTrue()
        {
            Triangle tri = new Triangle(5, 10.0, 15.5);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        // Sending in a Equilateral triangle and checking if triangle is Scalene, should return False.
        public void isScaleneTestEquilateralExpectFalse()
        {
            Triangle tri = new Triangle(10, 10.0, 10);
            Assert.IsFalse(tri.isScalene());
        }

        [TestMethod]
        // Sending in a Isosceles triangle and checking if triangle is Scalene, should return False.
        public void isScaleneTestIsoscelesExpectFalse()
        {
            Triangle tri = new Triangle(15, 15, 10);
            Assert.IsFalse(tri.isScalene());
        }

        [TestMethod]
        // Inserting three points, should pass just fine.
        public void ConstructorPointInsertingThreePointsExpectSuccess()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);
            Point c = new Point(5, 5);

            new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Inserting no element points, should cast an Exception.
        public void ConstructorPointInsertingZeroElementsTestExpectException()
        {
            new Triangle(new Point[] { });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Inserting one element points, should cast an Exception.
        public void ConstructorPointInsertingOneElementExpectException()
        {
            Point a = new Point(3, 3);

            new Triangle(new Point[] { a });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Inserting two elements points, should cast an Exception.
        public void ConstructorPointInsertingTwoElementsExpectException()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);

            new Triangle(new Point[] { a, b });
        }

        [TestMethod]
        // Inserting three elements points, should pass just fine.
        public void ConstructorPointInsertingThreeElementsExpectSuccess()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);
            Point c = new Point(5, 5);

            new Triangle(new Point[] { a, b, c });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Inserting four elements points, should cast an Exception.
        public void ConstructorPointInsertingFourElementsExpectException()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);
            Point c = new Point(5, 5);
            Point d = new Point(6, 6);

            new Triangle(new Point[] { a, b, c, d });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Inserting one element, should cast an Exception.
        public void ConstructorArrayInsertingOneElementsExpectException()
        {
            new Triangle(new double[] { 3 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Inserting two elements, should cast an Exception.
        public void ConstructorArrayInsertingTwoElementsExpectException()
        {
            new Triangle(new double[] { 3, 4 });
        }

        [TestMethod]
        // Inserting three elements, should pass just fine.
        public void ConstructorArrayInsertingThreeElementsExpectException()
        {
            new Triangle(new double[] { 3, 4, 5 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Inserting four elements, should cast an Exception.
        public void ConstructorArrayInsertingFourElementsExpectException()
        {
            new Triangle(new double[] { 3, 4, 5, 6 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        // Sending in a negative values, should cast an Exception.
        public void NegativeTestExpectException()
        {
            Triangle tri = new Triangle(new double[] { -3, -4.0, -5 });
        }

        [TestMethod]
        // Passing in three 2^64/2-1 INTs, should pass just fine.
        public void MaxINTValueExpectSuccess()
        {
            Triangle tri = new Triangle(new double[] { 9223372036854775807, 9223372036854775807, 9223372036854775807 });
        }
    }
}