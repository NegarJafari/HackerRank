using CatAndMouse;
using NUnit.Framework;

namespace CatAndMouseTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCatACloser()
        {
            // Arrange
            var hunt = new Hunt();
            var catA = 10;
            var catB = 2;
            var mouse = 7;
            var expected = "Cat A";

            // Act
            var result = hunt.CatAndMouse(catA, catB, mouse); 

            // Assert
            Assert.AreEqual(expected, result); 
        }

        [Test]
        public void TestCatBCloser()
        {
            // Arrange
            var hunt = new Hunt();
            var catA = 8;
            var catB = 4;
            var mouse = 5;
            var expected = "Cat B";

            // Act
            var result = hunt.CatAndMouse(catA, catB, mouse);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSameDistance()
        {
            // Arrange
            var hunt = new Hunt();
            var catA = 8;
            var catB = 2;
            var mouse = 5;
            var expected = "Mouse C";

            // Act
            var result = hunt.CatAndMouse(catA, catB, mouse);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}