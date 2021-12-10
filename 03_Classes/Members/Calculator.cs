using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Members
{
    public class Calculator
    {
        private Random _rng;
        // classes/objects = nouns
        // properties & fields = adjectives
        // methods = verbs

        // Make an Add method that takes in two numbers and returns the sum
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        // this one returns a double
        public double Add(double numOne, double numTwo)
        {
            double product = numOne * numTwo;
            return product;
            // return (numOne * numTwo);

            // Expression = some value or something that resolves to a value
            // e.g. 5+5, user.IsAdmin && loggedIn
        }


        // New method: Add All
        public double AddAll(double[] numbers)
        {
            double total = 0;
            foreach (double num in numbers)
            {
                total += num;
            }
            return total;
        }

        public double Average(double[] sdfdfgsdfgfds)
        {
            if (sdfdfgsdfgfds.Length == 0)
            {
                return 0;
            }

            double sum = AddAll(sdfdfgsdfgfds);

            double average = sum / sdfdfgsdfgfds.Length;
            return average;
        }


        // CHALLENGE: Create the following methods:
        // Multiply
        public double Multiply(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }
        // Divide (and give a decimal answer)
        public double Divide(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
        public double Divide(int x, int y)
        {
            double xDouble = Convert.ToDouble(x);
            double yDouble = (double) y; // casting (convert)
            return xDouble / yDouble;
            // return x / y;
        }
        // Remainder
        public int Remainder (int x, int y)
        {
            double quotient;
            return x % y;
        }

        // BONUS: Divide (and give a mixed number, like 3 1/4)
        public string DivideMixed(int x, int y)
        {
            int quotient = x / y;
            int numerator = Remainder(x, y);
            return $"{quotient} {numerator}/{y}";
        }
    }
}
