using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    //Attribute that lets us know that this is a testing class
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            //a declared variable.. Defaults to false
            bool isDeclared;
           
            //the assignment...
            isDeclared = true;

            //declaring and initializing at the same time..
            //left side of = is declaration and right side is initialization
            bool isDeclaredAndInitialized = false;

            //can call a variable by its name and assign it
            isDeclaredAndInitialized = true;

        }

        [TestMethod]
        public void Characters()
        {
            //char -> single character values
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255; //a group of binary digits or bits (usually eight) operated on as a unit. 32bytes make 256bits
            sbyte sByteMax = -128;  //small integer that can be negative or positive. It is 8 bits or 1 byte and it stores integers between -128 and 127.
            short shortExample = 32767; // reduces the memory usage of integers. It represents a number in 2 bytes—16 bits—half the size of an int.
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648; //negative two billion one hundred forty-seven million four hundred eighty-three thousand six hundred forty-eight
            int intMax = 2147483647; //two billion one hundred forty-seven million four hundred eighty-three thousand six hundred forty-eight
            long longExample = 9223372036854775807; //nine quintillion two hundred twenty-three quadrillion three hundred seventy-two trillion thirty-six billion eight hundred fifty-four million seven hundred seventy-five thousand eight hundred seven
            Int64 longMin = -9223372036854775808; // negative nine quintillion two hundred twenty-three quadrillion three hundred seventy-two trillion thirty-six billion eight hundred fifty-four million seven hundred seventy-five thousand eight hundred seven

            int a = 15;
            int b = -10;

            byte age = 25;
        }

        [TestMethod]
        public void Decimals()
        {
            
            float floatExample = 1.045231f;

            double doubleExample = 1.789053278907036d;

            //currency-> $
            decimal decimalExample = 1.2578907289045789789789789787897m;

            //these will truncate
            Console.WriteLine(1.2578907289045789789789789787897f); 
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);

        }

        enum PastryType { Cake, Cupcake, Eclaire, PetitFour, Croissant}

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;

            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1972, 6, 20);
        }

    }
}
