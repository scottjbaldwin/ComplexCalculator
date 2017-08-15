using System;

namespace ComplexCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program adds 2 complex numbers");
            ComplexNumber c1 = new ComplexNumber
            {
                Real = ReadDouble("Enter Real Part of first complex number"),
                Imaginary = ReadDouble("Enter Imaginary part of first complex number")
            };
            ComplexNumber c2 = new ComplexNumber
            {
                Real = ReadDouble("Enter Real Part of second complex number"),
                Imaginary = ReadDouble("Enter Imaginary part of second complex number")
            };

            var c3 = c1.Add(c2);

            Console.WriteLine("{0} + {1} = {2} with modulus {3}", c1, c2, c3, c3.Modulus());
        }

        private static double ReadDouble(string message)
        {
            double val;
            string s;
            bool success = false;
            do
            {
                Console.Write(message + ":");
                s = Console.ReadLine();
                success = double.TryParse(s, out val);
                if (!success)
                {
                    Console.WriteLine("ERROR please try again.");
                }
            } while (!success);

            return val;

        }
    }
}
