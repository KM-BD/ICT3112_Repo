using ICT3112_Calculator;
using NUnit.Framework;

namespace ICT3112_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            // Arrange 
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act          
            double result = _calculator.Add(10, 20);
            // Assert 
            Assert.That(result, Is.EqualTo(30));
        }
        /************************* Question 13 *************************/
        /************************* Subtract tests *************************/
        [Test]
        public void Subtract_WhenSubtractingNegativeNumbers_ResultEqualToCorrectDifference()
        {
            // Act
            double result = _calculator.Subtract(-10, -20);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Subtract_WhenSubtractingZeroFromNumber_ResultEqualToSameNumber()
        {
            // Act
            double result = _calculator.Subtract(10, 0);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        /************************* Multiply tests *************************/
        [Test]
        public void Multiply_WhenMultiplyingByZero_ResultEqualToZero()
        {
            // Act
            double result = _calculator.Multiply(10, 0);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_WhenMultiplyingWithNegativeNumbers_ResultEqualToCorrectProduct()
        {
            // Act
            double result = _calculator.Multiply(-10, 20);

            // Assert
            Assert.That(result, Is.EqualTo(-200));
        }

        /************************* Divide tests *************************/
        [Test]
        public void Divide_WhenDividingNegativeNumbers_ResultEqualToCorrectQuotient()
        {
            // Act
            double result = _calculator.Divide(-20, 10);

            // Assert
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Divide_WhenDividingSmallNumbers_ResultEqualToCorrectQuotient()
        {
            // Act
            double result = _calculator.Divide(0.0001, 0.0001);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(0, 0)]  // Both numerator and denominator are zero
        [TestCase(0, 10)] // Numerator is zero
        [TestCase(10, 0)] // Denominator is zero
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                // When both numerator and denominator are zero, expect the result to be 1
                var result = _calculator.Divide(a, b);
                Assert.That(result, Is.EqualTo(1));
            }
            else if (b == 0)
            {
                // When the denominator is zero, expect the result to be PositiveInfinity
                var result = _calculator.Divide(a, b);
                Assert.That(result, Is.EqualTo(double.PositiveInfinity));
            }
            else
            {
                // In all other cases, perform the division and verify the result
                var result = _calculator.Divide(a, b);
                Assert.That(result, Is.EqualTo(a / b));
            }
        }

        [Test]
        [TestCase(0, 1)]  // Factorial of 0 should be 1
        [TestCase(1, 1)]  // Factorial of 1 should be 1
        [TestCase(5, 120)]  // Factorial of 5 should be 120
        public void Factorial_WhenCalculatingFactorialOfValidNumbers_ResultEqualToExpected(int input, double expected)
        {
            // Act
            double result = _calculator.Factorial(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Factorial_WhenCalculatingFactorialOfNegativeNumber_ThrowsArgumentException()
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _calculator.Factorial(-5));
            Assert.That(ex.Message, Is.EqualTo("Factorial of a negative number is not defined."));
        }

        // Test case: 5! - 5 = 120
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);

            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        // Test case: 4! - 4 = 20
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);

            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        // Test case: 3! - 3 = 60
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);

            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        // Test case: Negative input should throw ArgumentException
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act & Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        // Test case: Negative input should throw ArgumentException
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act & Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, -5), Throws.ArgumentException);
        }

        // Test case: 5! / 5! = 1
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        // Test case: 5! / 4! = 5
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        // Test case: 5! / 3! = 10
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        // Test case: Negative input should throw ArgumentException
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act & Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }

        // Test case: Negative input should throw ArgumentException
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act & Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, -5), Throws.ArgumentException);
        }

        // Lab 4 Qn 8
        [Test]
        public void GenMagicNum_PositiveTestDependency_BuildSuccess()
        {
            var fileReader = new FileReader();            
            // Act
            double result = _calculator.GenMagicNum(1, fileReader);

            // Assert
            Assert.That(result, Is.EqualTo(4).Within(0.00001)); // Adjust tolerance for floating-point precision
        }

        [Test]
        public void GenMagicNum_NegativeTestDependency_BuildSuccess()
        {
            var fileReader = new FileReader();
            // Act
            double result = _calculator.GenMagicNum(-2, fileReader);

            // Assert
            Assert.That(result, Is.EqualTo(4).Within(0.00001)); // Adjust tolerance for floating-point precision
        }

        [Test]
        public void GenMagicNum_IndexBeyondLength_ReturnsDoublePositive()
        {
            // Arrange
            var fileReader = new FileReader();            

            // Act
            double result = _calculator.GenMagicNum(10, fileReader);

            // Assert
            Assert.That(result, Is.EqualTo(20));
        }
        }
}