using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqareFind;
using System;

namespace SquareFindLibTest
{
    [TestClass]
    public class UnitTest1
    {
        // положительный тест поиска площади круга
        [TestMethod]
        public void Radius10CirclePositiveTest()
        {
            Circle circle = new Circle(10);
            var expected = Math.PI * 100;
            var actual = circle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        // отрицательный радиус круга
        [TestMethod]
        public void NegativeRadiusCircleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-10));
        }

        // нулевой радиус круга
        [TestMethod]
        public void ZeroRadiusCircleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
            
        }

        // положительный тест поиска площади треугольника
        [TestMethod]
        public void Sides3_4_5TrianglePositiveTest()
        {
            Triangle triangle = new Triangle(3,4,5);
            var expected = 6;
            var actual = triangle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        // тест на построение невозможных треугольников
        [TestMethod]
        public void ImpossibleTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 3, 6));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(6, 3, 3));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 3, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 5, 3));
        }

        // тест на негативные стороны
        [TestMethod]
        public void NegativeSideTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 3, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, -1, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 3, -1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, -1, -1));
        }

        // тест на нулевые стороны
        [TestMethod]
        public void ZeroSideTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 3, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 0, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 3, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));
        }

        // положительный тест на прямоугольный треугольник
        [TestMethod]
        public void IsRightTrianglePositiveTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle);
        }

        // отрицательный тест на прямоугольный треугольник
        [TestMethod]
        public void IsRightTriangleNegativeTest()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle);
        }
    }
}