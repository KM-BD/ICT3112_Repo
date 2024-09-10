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
            // Added to handle corner cases where there is 0
            if (a == 0 && b == 0)
            {
                // Act & Assert
                var ex = Assert.Throws<ArgumentException>(() => _calculator.Divide(a, b));
                Assert.That(ex.Message, Is.EqualTo("Both numerator and denominator cannot be zero."));
            }
            else if (b == 0)
            {
                // Act & Assert
                Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
            }
            else
            {
                // In case no exception is expected
                Assert.DoesNotThrow(() => _calculator.Divide(a, b));
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

    }
}