using NUnit.Framework;
using NUnitDemonstration;

// Student Name: Jaspreet Singh
namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest
    {
        // Test case for equilateral Traingle
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            //Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";

            //Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test case for invalid triangle
        [Test]
        public void InValidTriangle_Input60and700and60_OutputInValidTriangle()
        {
            //Arrange
            int firstAngle = 60;
            int secondAngle = 700;
            int thirdAngle = 60;

            string expected = "The triangle is NOT valid.";

            //Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test cases for Right triangle
        [TestCase(90, 60, 30)]
        [TestCase(30, 90, 60)]
        [TestCase(90, 30, 60)]
        public void ValidTriangle_RightAngleTriangle_OutputValidTriangle(int firstAngle,
            int secondAngle,
            int thirdAngle)
        {
            //Arrange
            string expected = "The triangle is valid.";

            //Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test cases for obtuse triangle
        [TestCase(45, 100, 35)]
        [TestCase(100, 45, 35)]
        [TestCase(35, 100, 45)]
        public void ValidTriangle_ObtuseAngleTriangle_OutputValidTriangle(int firstAngle,
            int secondAngle,
            int thirdAngle)
        {
            //Arrange
            string expected = "The triangle is valid.";

            //Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test cases for acute triangle
        [TestCase(70, 45, 65)]
        [TestCase(45, 70, 65)]
        [TestCase(65, 45, 70)]
        public void ValidTriangle_AcuteTriangle_OutputValidTriangle(int firstAngle,
            int secondAngle,
            int thirdAngle)
        {
            //Arrange
            string expected = "The triangle is valid.";

            //Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test cases for invalid triangles
        [TestCase(80, 100, 60)]
        [TestCase(50, 60, 40)]
        [TestCase(100, 45, 65)]
        public void InValidTriangle_ForMultipleCases_OutputInValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            //Arrange
            string expected = "The triangle is NOT valid.";

            //Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
