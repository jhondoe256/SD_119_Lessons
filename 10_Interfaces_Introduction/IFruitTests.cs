using _10_Interfaces_Introduction.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _10_Interfaces_Introduction
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            //we can do this b/c Banana 'has a'  IFruit ->contract
            IFruit banana = new Banana();

            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            //start with an orange...
            Orange orange = new Orange();

            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                orange,
                //new SourApple()
            };

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                Assert.IsInstanceOfType(fruit, typeof(IFruit));

            }

            Console.WriteLine(orange.Squeeze());
            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        //Method that takes in a Parameter of type IFruit
        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}.";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            //make a instance of a class that implements IFruit
            Grape grape = new Grape();

            var output = GetFruitName(grape);

            Console.WriteLine(output);

            Assert.IsTrue(output.Contains("This fruit is called Grape."));

        }

        //want a list of IFruit objects and we want to iterate over them 
        //as loop through them we will perform a different task
        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            foreach (var fruit in fruitSalad)
            {
                //Pattern Matching
                if (fruit is Orange orange)//different way of casting 
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("Is a peeled Orange.");
                        orange.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("Is a Orange.");
                    }
                }
                else if (fruit.GetType()==typeof(Grape))
                {
                    Console.WriteLine("Is a Grape.");

                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("Is a Peeled Banana.");
                }
                else
                {
                    Console.WriteLine("Is a Banana.");
                }
            }
        }
    }
}
