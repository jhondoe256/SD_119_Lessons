using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            //something simple...
            bool userIsHungry = false;
            if (userIsHungry==true)
            {
                Console.WriteLine("Eat something....");
            }

            //Another one..
            int hoursSpentStudying = 1;
            if (hoursSpentStudying <16)
            {
                Console.WriteLine("Are you even trying....");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = true;
            if (choresAreDone)// this is the condition for the if/else
            {
                Console.WriteLine("Have fun at the Movies!");
            }
            else
            {
                Console.WriteLine("You must stay home and finsh your chores!");
            }

            //YOU CANNOT HAVE AN ELSE W/O AN IF

            //simulate userInput....
            
            
            string input = "3";
            //Turns string into a number....
            int totalHours = int.Parse(input);

            if (totalHours >=8 )//first if
            {
                Console.WriteLine("You should be well rested.");
            }
            else //first else...
            {
                Console.WriteLine("You might be tired today.");
                //use branching...
                if (totalHours<4)
                {
                    Console.WriteLine("You should get some sleep.");
                }
            }

            //Stacking Conditions...
            int age = 7;
            if (age >17)
            {
                Console.WriteLine("You are an Adult.");
            }
            else
            {
                if (age>6)
                {
                    Console.WriteLine("You're a Kid.");
                }
                else if (age >0)
                {
                    Console.WriteLine("You're far too young to be on a computer.");
                }
                else
                {
                    Console.WriteLine("You are not born yet.");
                }
            }

            //using AND, OR, AND EQUAL
            if (age <65 && age >18)
            {
                Console.WriteLine("Age is between 18 and 65.");
            }

            if (age > 65 || age <18)
            {
                Console.WriteLine("Age is either greater than 65 or less than 18.");
            }

            //EQUAL
            if (age == 21)
            {
                Console.WriteLine("Age is equal to 21.");
            }
                  //Bang Operator ! 
            if (age != 36)
            {
                Console.WriteLine("Age is not equal to 36.");
            }

        }
    }
}
