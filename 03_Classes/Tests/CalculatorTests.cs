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
    }
}
