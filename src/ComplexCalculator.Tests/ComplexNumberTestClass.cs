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

        [Theory()]
        [InlineData(1, 2, 1, 2, 2, 4)]
        [InlineData(1, 1, -1, -1, 0, 0)]
        [InlineData(1, 3, -2, -5, -1, -2)]
        void WhenComplexNumbersAdded_TheirRealPartsAndImaginaryPartsAreAdded(double r1, double i1, double r2, double i2, double r3, double i3)
        {
            // Arrange
            var n1 = new ComplexNumber { Real = r1, Imaginary = i1 };
            var n2 = new ComplexNumber { Real = r2, Imaginary = i2 };

            // Act
            var n3 = n1.Add(n2);

            // Assert
            Assert.Equal(r3, n3.Real);
            Assert.Equal(i3, n3.Imaginary);
        }
    }
}
