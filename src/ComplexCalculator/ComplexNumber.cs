using System;

namespace ComplexCalculator
{
    public class ComplexNumber
    {
        public double Real { get; set; }

        public double Imaginary { get; set; }

        public double Modulus()
        {
            return Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }

        public override string ToString()
        {
            var sign = Imaginary > 0 ? "+" : "";
            return $"{Real}{sign}{Imaginary}i";
        }

        public ComplexNumber Add(ComplexNumber num)
        {
            return new ComplexNumber
            {
                Real = this.Real + num.Real,
                Imaginary = this.Imaginary + num.Imaginary
            };
        }
    }
}
