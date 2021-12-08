using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Terry";

            //to check if something is equal in C# (==)
            bool equals = age == 41;
            bool userIsAdam = userName == "Adam";

            Console.WriteLine(equals);
            Console.WriteLine(userIsAdam);

            //Checking inequality in C# (! -> bang operator)
            //its followed by the = sign (!=)
            bool notEqual = age != 122;
            bool notIsUserName = userName != "Justin";
            Console.WriteLine($"User is not 122: {notEqual}");
            Console.WriteLine($"User is not Justin: {notIsUserName}");

            //Reference type comparison
            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are the same: {listAreEqual}");

            secondList = firstList;

            listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are the same: {listAreEqual}");

            //other comparisons
            bool greaterThan = age > 22;
            //>=
            bool greaterThanOrEqualTo = age >= 24;
            //<
            bool lessthan = age < 66;
            //<=
            bool lessThanOrEqualTo = age <= 24;

            //or || -> either one of these can be true
            bool orValue = equals || lessthan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True  or False: {tOrF}");
            Console.WriteLine($"False or True:{fOrT}");
            Console.WriteLine($"False or False:{fOrF}");

            //And comparison && 
            bool andValue = greaterThan && orValue;
            bool tandT = trueValue && trueValue;
            bool tandF = trueValue && falseValue;
            bool fandT = falseValue && trueValue;
            bool fandF = falseValue && falseValue;
            Console.WriteLine($"True and True: {tandT}");
            Console.WriteLine($"True and false: {tandF}");
            Console.WriteLine($"false and True: {fandT}");
            Console.WriteLine($"false and false: {fandF}");

        }
    }
}
