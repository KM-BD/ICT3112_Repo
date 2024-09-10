using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ICT3112_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value 
            // Use a switch statement to do the math. 
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor. 
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Factorial for the first number
                    result = Factorial((int)num1);
                    break;
                // Return text for an incorrect option entry. 
                default:
                    break;
            }
            return result;
        }

        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            /* Question 13b Changes to handle division by 0 and cases where both are 0*/
            if (num1 == 0 && num2 == 0)
            {
                throw new ArgumentException("Both numerator and denominator cannot be zero.");
            }
            if (num2 == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }

            return num1 / num2;
        }

        // New Factorial method
        // Factorial helper function
        public double UnknownFunctionA(int a, int b)
        {
            if (a < 0 || b < 0 || a < b)
            {
                throw new ArgumentException("Invalid input values");
            }
            return Factorial(a) / Factorial(a - b);
        }

        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial of a negative number is not defined.");
            }
            if (n == 0 || n == 1) return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public double UnknownFunctionB(int n, int k)
        {
            if (n < 0 || k < 0 || n < k)
            {
                throw new ArgumentException("Invalid input values");
            }

            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        /////////////////Triangle Stuff
        public double TriangleArea(double height, double baseLength)
        {
            if (height < 0 || baseLength < 0)
            {
                throw new ArgumentException("Height and base length must be non-negative.");
            }

            return 0.5 * baseLength * height;
        }

        public double CircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be non-negative.");
            }

            return Math.PI * radius * radius;
        }
    }

}
