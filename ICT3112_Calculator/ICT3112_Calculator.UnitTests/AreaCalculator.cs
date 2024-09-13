using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3112_Calculator.UnitTests
{
    public class AreaCalculator
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            // Arrange 
            _calculator = new Calculator();
        }
        //Triangle Area
        [Test]
        public void TriangleArea_GivenHeightAndBase_ShouldReturnCorrectArea()
        {
            // Arrange
            double height = 10;
            double baseLength = 5;

            // Act
            double result = _calculator.TriangleArea(height, baseLength);

            // Assert
            Assert.That(result, Is.EqualTo(25)); // 0.5 * 10 * 5 = 25
        }

        [Test]
        public void TriangleArea_GivenZeroHeight_ShouldReturnZero()
        {
            // Arrange
            double height = 0;
            double baseLength = 5;

            // Act
            double result = _calculator.TriangleArea(height, baseLength);

            // Assert
            Assert.That(result, Is.EqualTo(0)); // 0.5 * 0 * 5 = 0
        }

        [Test]
        public void TriangleArea_GivenZeroBase_ShouldReturnZero()
        {
            // Arrange
            double height = 10;
            double baseLength = 0;

            // Act
            double result = _calculator.TriangleArea(height, baseLength);

            // Assert
            Assert.That(result, Is.EqualTo(0)); // 0.5 * 10 * 0 = 0
        }

        [Test]
        public void TriangleArea_GivenNegativeValues_ShouldThrowArgumentException()
        {
            // Arrange
            double height = -10;
            double baseLength = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.TriangleArea(height, baseLength));
        }

        // Circle Tests
        [Test]
        public void CircleArea_GivenRadius_ShouldReturnCorrectArea()
        {
            // Arrange
            double radius = 5;

            // Act
            double result = _calculator.CircleArea(radius);

            // Assert
            Assert.That(result, Is.EqualTo(Math.PI * 25).Within(0.0001)); // pi * r^2 = pi * 5^2 = 25 * pi
        }

        [Test]
        public void CircleArea_GivenZeroRadius_ShouldReturnZero()
        {
            // Arrange
            double radius = 0;

            // Act
            double result = _calculator.CircleArea(radius);

            // Assert
            Assert.That(result, Is.EqualTo(0)); // pi * 0^2 = 0
        }

        [Test]
        public void CircleArea_GivenNegativeRadius_ShouldThrowArgumentException()
        {
            // Arrange
            double radius = -5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CircleArea(radius));
        }
    }
}
