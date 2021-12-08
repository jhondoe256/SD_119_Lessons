using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //Addition 
            int sum = a + b;
            Console.WriteLine(sum);

            //Subtraction
            int difference = a - b;
            Console.WriteLine(difference);

            //Multiplication * 
            int product = a * b;
            Console.WriteLine(product);

            //Division /
            int quotient = a / b;
            Console.WriteLine(quotient);


            //Remainder %
            //This is sometimes called modulus
            int remainder = a % b;
            Console.WriteLine(remainder);

            //We can use DateTimes
            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);

            //do the calculation
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan.Days);
        }
    }
}
