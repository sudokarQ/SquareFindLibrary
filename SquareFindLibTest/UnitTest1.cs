using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqareFind;
using System;

namespace SquareFindLibTest
{
    [TestClass]
    public class UnitTest1
    {
        // ������������� ���� ������ ������� �����
        [TestMethod]
        public void Radius10CirclePositiveTest()
        {
            Circle circle = new Circle(10);
            var expected = Math.PI * 100;
            var actual = circle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        // ������������� ������ �����
        [TestMethod]
        public void NegativeRadiusCircleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-10));
        }

        // ������� ������ �����
        [TestMethod]
        public void ZeroRadiusCircleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
            
        }

        // ������������� ���� ������ ������� ������������
        [TestMethod]
        public void Sides3_4_5TrianglePositiveTest()
        {
            Triangle triangle = new Triangle(3,4,5);
            var expected = 6;
            var actual = triangle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        // ���� �� ���������� ����������� �������������
        [TestMethod]
        public void ImpossibleTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 3, 6));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(6, 3, 3));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 3, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 5, 3));
        }

        // ���� �� ���������� �������
        [TestMethod]
        public void NegativeSideTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 3, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, -1, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 3, -1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, -1, -1));
        }

        // ���� �� ������� �������
        [TestMethod]
        public void ZeroSideTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 3, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 0, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 3, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));
        }

        // ������������� ���� �� ������������� �����������
        [TestMethod]
        public void IsRightTrianglePositiveTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle);
        }

        // ������������� ���� �� ������������� �����������
        [TestMethod]
        public void IsRightTriangleNegativeTest()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle);
        }
    }
}