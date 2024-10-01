using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3112_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "-42" });
            _calculator = new Calculator();
        }
        // Lab 4 Qn 8
        [Test]
        public void GenMagicNum_PositiveTestDependency_BuildSuccess()
        {
            // Act
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);

            // Assert
            Assert.That(result, Is.EqualTo(84).Within(0.00001));  // 2.0 * 2 = 4
        }

        [Test]
        public void GenMagicNum_NegativeTestDependency_BuildSuccess()
        {
            // Act
            double result = _calculator.GenMagicNum(-2, _mockFileReader.Object);

            // Assert
            Assert.That(result, Is.EqualTo(0).Within(0.00001));  // Result of -2 will be handled in the else block
        }

        [Test]
        public void GenMagicNum_IndexBeyondLength_ReturnsDoublePositive()
        {
            // Act
            double result = _calculator.GenMagicNum(10, _mockFileReader.Object);  // Input beyond array length

            // Assert
            Assert.That(result, Is.EqualTo(0));  // 10 * 2 = 20
        }
    }
}
