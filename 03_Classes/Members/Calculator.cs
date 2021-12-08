using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Members
{
    public class Calculator
    {
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
            return numOne + numTwo;
        }
    }
}
