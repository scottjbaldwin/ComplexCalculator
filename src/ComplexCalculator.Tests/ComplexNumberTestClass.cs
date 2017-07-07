using Xunit;

namespace ComplexCalculator.Tests
{
    public class ComplexNumberTestClass
    {
        [Fact]
        public void WhenRealPartSet_ItCanBeReturned()
        {
            // Arrange
            var num = new ComplexNumber();

            // Act
            num.Real = 42;

            // Assert
            Assert.Equal(42, num.Real);
        }

        [Fact]
        public void WhenImaginaryPartSet_ItCanBeReturned()
        {
            // Arrange
            var num = new ComplexNumber();

            // Act
            num.Imaginary = 13;

            // Assert
            Assert.Equal(13, num.Imaginary);
        }
    }
}
