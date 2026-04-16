using CalculatorTest.Services;

namespace CalculatorTest.Tests
{
    public class SimpleCalculatorTests
    {
        private readonly SimpleCalculator _calculator = new();

        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            Assert.Equal(15, _calculator.Add(10, 5));
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            Assert.Equal(5, _calculator.Subtract(10, 5));
        }

        [Fact]
        public void Add_WithZero_ReturnsSameValue()
        {
            Assert.Equal(10, _calculator.Add(10, 0));
        }

        [Fact]
        public void Subtract_WithZero_ReturnsSameValue()
        {
            Assert.Equal(10, _calculator.Subtract(10, 0));
        }

        [Fact]
        public void Add_WithNegativeNumbers_ReturnsCorrectResult()
        {
            Assert.Equal(-5, _calculator.Add(-10, 5));
        }

        [Fact]
        public void Subtract_WithNegativeNumbers_ReturnsCorrectResult()
        {
            Assert.Equal(-15, _calculator.Subtract(-10, 5));
        }

        [Fact]
        public void Add_WithBothNegative_ReturnsCorrectResult()
        {
            Assert.Equal(-15, _calculator.Add(-10, -5));
        }

        [Fact]
        public void Subtract_WithBothNegative_ReturnsCorrectResult()
        {
            Assert.Equal(-5, _calculator.Subtract(-10, -5));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(100, 200, 300)]
        [InlineData(-50, 50, 0)]
        public void Add_WithMultipleInputs_ReturnsCorrectResult(int start, int amount, int expected)
        {
            Assert.Equal(expected, _calculator.Add(start, amount));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(300, 200, 100)]
        [InlineData(50, 50, 0)]
        public void Subtract_WithMultipleInputs_ReturnsCorrectResult(
            int start,
            int amount,
            int expected
        )
        {
            Assert.Equal(expected, _calculator.Subtract(start, amount));
        }
    }
}
