using JumpingOnTheClouds;

namespace jumpingOnCloudsTest
{
    public class JumpTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CloudsLenght6JumpTest1()
        {
            //Arrang
            var clouds = new List<int>() { 0, 0, 0, 1, 0, 0 };
            var expected = 3;

            //Act
            var jump = new Jump();
            var result = jump.jumpingOnClouds(clouds);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void CloudsLenght6JumpTest2()
        {
            //Arrang
            List<int> clouds = new List<int>() { 0, 1, 0, 1, 0, 0 };
            var expected = 3;

            //Act
            var jump = new Jump();
            var result = jump.jumpingOnClouds(clouds);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void CloudsLenght6JumpTest3()
        {
            //Arrang
            List<int> clouds = new List<int>() { 0, 0, 0, 0, 0, 0 };
            var expected = 3;

            //Act
            var jump = new Jump();
            var result = jump.jumpingOnClouds(clouds);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void CloudsLenght6JumpTest4()
        {
            //Arrang
            var clouds = new List<int>() { 0, 0, 1, 0, 0, 1 };
            var expected = 0;

            //Act
            var jump = new Jump();
            var result = jump.jumpingOnClouds(clouds);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void CloudsLengh7JumpTest1()
        {
            //Arrang
            var clouds = new List<int>() { 1, 0, 0, 1, 0, 1, 0 };
            var expected = 0;

            //Act
            var jump = new Jump();
            var result = jump.jumpingOnClouds(clouds);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void CloudsLenght7JumpTest2()
        {
            //Arrang
            var clouds = new List<int>() { 0, 0, 0, 0, 0, 1, 0 };
            var expected = 3;

            //Act
            var jump = new Jump();
            var result = jump.jumpingOnClouds(clouds);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }
        [Test]
        public void CloudsLenght8JumpTest1()
        {
            //Arrang
            var clouds = new List<int>() { 0, 1, 0, 1, 0, 1, 0, 0 };
            var expected = 4;

            //Act
            var jump = new Jump();
            var result = jump.jumpingOnClouds(clouds);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}