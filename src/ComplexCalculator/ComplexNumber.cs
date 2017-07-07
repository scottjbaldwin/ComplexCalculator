using System;

namespace ComplexCalculator
{
    public class ComplexNumber
    {
        public double Real { get; set; }

        public double Imaginary { get; set; }

        public double Modulous()
        {
            return Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }
    }
}
