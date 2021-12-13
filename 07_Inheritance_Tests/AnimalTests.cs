using _06_Inheritance_Classes.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_Inheritance_Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void AnimalTest()
        {
            // Animal is abstract so we can't "new one up" any more

            /*
            Animal animal = new Animal();
            animal.NumberOfLegs = 6;
            animal.Move();
            Console.WriteLine(animal.HasFur);
            Console.WriteLine(animal.NumberOfLegs);
            */
        }

        [TestMethod]
        public void MammalTest()
        {
            Mammal mammal = new Mammal("orange");
            mammal.Move();
            mammal.MakeSound();
            Console.WriteLine(mammal.NumberOfLegs);
            Console.WriteLine(mammal.HasFur);
            Console.WriteLine(mammal is Cat);
        }

        [TestMethod]
        public void CatTest()
        {
            Cat nancy = new Cat("tabby");
            Console.WriteLine((int) nancy.DietType);
            Console.WriteLine(nancy is Cat);
            Console.WriteLine(nancy is Mammal);
            Console.WriteLine(nancy is Animal);

            nancy.MakeSound();
        }
    }
}
