using NUnit.Framework;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }
    }
}