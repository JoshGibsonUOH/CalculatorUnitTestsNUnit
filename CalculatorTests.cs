namespace CalculatorNUnitTests
{
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            double result = Calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void TestSubtract()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            double result = Calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestMultiply()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            double result = Calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void TestDivide()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            double result = Calculator.Divide(num1, num2);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}