using _03_Classes.Members;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calc = new Calculator();

            double quotient = calc.Divide(10, 3);
            Console.WriteLine(quotient);
            Console.WriteLine(calc.DivideMixed(10, 3));
        }

        [TestMethod]
        public void NewMethodsTest()
        {
            Calculator calc = new Calculator();

            double[] fibonacci = { 1, 1, 2, 3, 5, 8, 13, 21 };

            double sum = calc.AddAll(fibonacci);
            Console.WriteLine($"Sum: {sum}");

            double avg = calc.Average(fibonacci);
            Console.WriteLine($"Average: {avg}");

            double[] empty = { };
            Console.WriteLine($"Average 2: {calc.Average(empty)}");

        }
    }
}
