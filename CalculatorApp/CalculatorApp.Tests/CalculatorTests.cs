namespace CalculatorApp.Tests
{
    using Xunit;

    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = Calculator.Add(3, 5);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            int result = Calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int result = Calculator.Multiply(4, 3);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            double result = Calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(5, 0));
        }
    }
}