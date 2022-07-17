using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SquareFind;



namespace SquareLibrary_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }
    }
}