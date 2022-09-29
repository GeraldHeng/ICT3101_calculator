using ICT3101_Calculator;

namespace ICT3101_Caculator.UnitTests
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

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(20, 5);
            // Assert
            Assert.That(result, Is.EqualTo(15));
        }


        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToValue()
        {
            var result = _calculator.Multiply(2, 5);

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDividedValue()
        {
            var result = _calculator.Divide(10, 5);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZeroAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WhenFactoringANumber_ResultEqualToFactorialValue()
        {
            var result = _calculator.Factorial(4);

            Assert.That(result, Is.EqualTo(24));
        }

        [Test]
        public void Factorial_WithZeroAsInput_ResultEqualToOne()
        {
            var result = _calculator.Factorial(0);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Factorial_WithNegativeNumberAsInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-2), Throws.ArgumentException);
        }

        [Test]
        public void AreaTriangle_WhenCalculatingAreaOfTriangle_ResultEqualToCalculatedArea()
        {
            var result = _calculator.AreaTriangle(2, 4);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void AreaCircle_WhenCalculatingAreaOfCircle_ResultEqualToCalculatedArea()
        {
            var result = _calculator.AreaCircle(2);

            Assert.That(result, Is.EqualTo(12.566));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}