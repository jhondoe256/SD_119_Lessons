using _03_Classes.Members;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes.Tests
{
    [TestClass]
    public class GreeterTest
    {
        [TestMethod]
        public void SayHelloTest()
        {
            Greeter greeter = new Greeter();

            //               argument = the value given to a parameter
            greeter.SayHello("Andrew");
            greeter.SayHello("Brandon");
            greeter.SayHello("Stacy");
            greeter.SayHello("Patom");
            greeter.SayHello("");

            greeter.GetRandomGreeting();
        }
    }
}
