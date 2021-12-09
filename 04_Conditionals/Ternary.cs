using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            //one liner if statements...
            int age = 31;
                          //Condition    ?   trueResult  :    falseResult
            bool isAdult = (age > 17)    ?  true        :    false ;
            Console.WriteLine($"Age is over 17: {isAdult}");

            int numOne = 10;
            //if numOne is 10 then we store the value 30, else we store the vale 20
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            //passing into the Console.WriteLine...
            Console.WriteLine((numTwo ==30)? "True" : "False");
        }
    }
}
