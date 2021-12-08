using _03_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person = new Person();
            person.FirstName = "Andrew";
            person.LastName = "torr";
            person.DateOfBirth = new DateTime(1985, 9, 22);

            Vehicle myCar = new Vehicle();
            myCar.Make = "Dodge";
            myCar.Model = "Journey";
            // ...etc

            person.Vehicle = myCar;

            Console.WriteLine($"My name is {person.FirstName} {person.LastName} and I drive a {person.Vehicle.Make} {person.Vehicle.Model}");
            Console.WriteLine($"{person.FirstName} is {person.Age} years old");

            Person otherPerson = new Person("Terry", "Brown", new DateTime(2001, 01, 01));

        }
    }
}
