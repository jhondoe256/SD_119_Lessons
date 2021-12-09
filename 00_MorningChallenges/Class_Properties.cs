using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_MorningChallenges
{
    [TestClass]
    public class Class_Properties
    {
        [TestMethod]
        public void Create_User_ShouldGiveMeAUser()
        {
            User user = new User();
            user.FirstName = "Bill";
            user.LastName= "Bob";
            user.BirthDate = new DateTime(2010, 07, 03);

            Console.WriteLine(user.HiMyNameIs());

            Console.WriteLine(user.UserAge());

            User user1 = new User(123, "Terry", "Brown", new DateTime(2010, 07, 18));

            Console.WriteLine($"Id: {user1.ID}\n" +
                              $"Name: {user1.HiMyNameIs()}\n" +
                              $"DOB: {user1.BirthDate}\n" +
                              $"Age: {user1.UserAge()}\n");
        }
    }
}
