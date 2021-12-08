using _03_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes.Tests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Room room = new Room(5, 8, 13);

            Console.WriteLine(room.SquareFootage);
            Console.WriteLine(room.WallSurfaceArea);
            Console.WriteLine(room.Volume);
        }
    }
}
