using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 0;

            while (total < 10)
            {
                // ++ before means it adds 1 before using the number
                // ++ after means it adds 1 after using it
                Console.WriteLine(++total);
                // total = total + 1;
                // total += 2;
                // total++;
            }

            total = 0;
            while (true)
            {
                if (total++ == 10)
                {
                    Console.WriteLine("Goal reached!");
                    break;
                }
            }

            Random rng = new Random();
            int someNumber;
            bool keepLooping = true;

            while (keepLooping)
            {
                someNumber = rng.Next(0, 20);

                if (someNumber == 6 || someNumber == 10)
                {
                    continue;
                }

                Console.WriteLine(someNumber);

                if (someNumber == 15)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 16;
            // 1 - Initial action - happens once at the start
            // 2 - Loop Condition - keep looping while this == true
            // 3 - Iterative action - happens at the end of every loop
            // 4 - The Loop - the code that is repeated
            //        1          2             3
            for (int i = 0; i < studentCount; i++)
            {
                // 4
                Console.WriteLine(i);
            }

            Random rng = new Random();
            for (int i = 0; i != 10; i = rng.Next(0, 20))
            {
                Console.WriteLine(i);
            }

            string[] students = { "Jonah", "Andrew L", "Andrew S", "Brandon", "Doug" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            // specific to collections/IEnumerable
            foreach (string student in students)
            {
                Console.WriteLine($"Welcome to class, {student}!");
            }

            foreach (char letter in "Andrew Torr")
            {
                Console.WriteLine(letter);
            }
        }


        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            } while (iterator < 5);

            do
            {
                Console.WriteLine("this should only happen once");
            } while (false);

            while (false)
            {
                Console.WriteLine("This should never happen!");
            }
        }
    }
}
