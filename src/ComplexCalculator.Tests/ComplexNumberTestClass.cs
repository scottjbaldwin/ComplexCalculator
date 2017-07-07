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

        [Fact]
        public void WhenModulousIsCalled_ItIsCalculatedAndReturned()
        {
            // Arrange
            var num = new ComplexNumber { Real = 3, Imaginary = 4 };

            // Act
            var mod = num.Modulous();

            // Assert
            Assert.Equal(5, mod);
        }

        [Theory()]
        [InlineData(3.5, -2.8, "3.5-2.8i")]
        [InlineData(7.2, 4.1, "7.2+4.1i")]
        public void WhenToStringCalled_ReturnsStringREpresentationOfComplexNumber(double real, double imaginary, string result)
        {
            // Arrange
            var num = new ComplexNumber { Real = real, Imaginary = imaginary };

            // Act
            var str = num.ToString();

            // Assert
            Assert.Equal(result, str);
        }
    }
}
