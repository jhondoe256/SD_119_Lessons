using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsADeclaration;

            thisIsADeclaration = "Hello World!";

            //Declaration and initialization
            string declarationAndInitialization = "This is both declaring and initializing.";

            //-Manipulating Strings
            string firstName = "Terry";
            string lastName = "Brown";

            //concatinate strings
            string concatenatedFullName = firstName + " " + lastName;

            //composite strings
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            //string interpolation
            string interpolatedExample = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedExample);
        }

        [TestMethod]
        public void Collections()
        {
            //--Arrays (Fixed collection)
            //this string value is a collection of char..
            string stringExample = "Hello World!";

            //this can hold only 5 values..
            //from [0] ->[4]
            //all arrays start a index 0
            string[] stringArray = new string[5];
            stringArray[0] = "Terry";
            stringArray[1] = "Loves";
            stringArray[2] = "to ";
            stringArray[3] = "Teach";
            stringArray[4] = "C#";

            string[] stringArray2 = {"Andrew","Also","Loves","To Teach C#" };
            Console.WriteLine(stringArray2[3]);

            //--Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("1234");// index 0
            listOfStrings.Add("Another string value."); //index 1

            Console.WriteLine(listOfStrings[0]);

            //--Queues F.I.F.O (First In First Out)
            // think of this as being in line
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First.");
            firstInFirstOut.Enqueue("I'm Next.");

            string whosNextInLine = firstInFirstOut.Peek();
            Console.WriteLine(whosNextInLine);

            firstInFirstOut.Dequeue();

             whosNextInLine = firstInFirstOut.Peek();
            Console.WriteLine(whosNextInLine);

            //--Dictionaries (Key/value pair)
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(1, "Terry");
            keyAndValue.Add(2, "Andrew");

            string agentName = keyAndValue[2];
            Console.WriteLine(agentName);

            //--Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

        }

        [TestMethod]
        public void Classes()
        {
            //use the new keyword-> this is an instance
            Random rnd = new Random();

            //use the dot operator to use a method in the Random Class
            int randomNumber =rnd.Next();

            Console.WriteLine(randomNumber);
        }
    }
}
