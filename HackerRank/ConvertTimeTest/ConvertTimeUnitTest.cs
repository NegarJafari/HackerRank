using HackerRank;

namespace ConvertTimeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMidNightAM()
        {
            //Arrange
            var convertor = new ConvertTime();
            string time = "12:58:03AM";
            var excepted = "00:58:03";

            //Act
            var result = convertor.timeConversion(time);

            //Assert
            Assert.AreEqual(excepted, result);
        }

        [Test]
        public void TestMorningAM()
        {
            //Arrange
            var convertor = new ConvertTime();
            string time = "05:10:25AM";
            var excepted = "05:10:25";

            //Act
            var result = convertor.timeConversion(time);

            //Assert
            Assert.AreEqual(excepted, result);
        }

        [Test]
        public void TestMmiddayAM()
        {
            //Arrange
            var convertor = new ConvertTime();
            string time = "11:50:25AM";
            var excepted = "11:50:25";

            //Act
            var result = convertor.timeConversion(time);

            //Assert
            Assert.AreEqual(excepted, result);
        }

        [Test]
        public void TestNoonPM()
        {
            //Arrange
            var convertor = new ConvertTime();
            string time = "12:12:12PM";
            var excepted = "12:12:12";

            //Act
            var result = convertor.timeConversion(time);

            //Assert
            Assert.That(result, Is.EqualTo(excepted));
        }

        [Test]
        public void TestAfternoonPM()
        {
            //Arrange
            var convertor = new ConvertTime();
            string time = "01:05:55PM";
            var excepted = "13:05:55";

            //Act
            var result = convertor.timeConversion(time);

            //Assert
            Assert.That(result, Is.EqualTo(excepted));
        }

        
        [Test]
        public void TestEveningPM()
        {
            //Arrange
            var convertor = new ConvertTime();
            string time = "06:06:56PM";
            var excepted = "18:06:56";

            //Act
            var result = convertor.timeConversion(time);

            //Assert
            Assert.That(result, Is.EqualTo(excepted));
        }

        [Test]
        public void TestNightPM()
        {
            //Arrange
            var convertor = new ConvertTime();
            string time = "09:45:44PM";
            var excepted = "21:45:44";

            //Act
            var result = convertor.timeConversion(time);

            //Assert
            Assert.That(result, Is.EqualTo(excepted));
        }

    }
}