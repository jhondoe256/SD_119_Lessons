using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to make a meal");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();

            potato.Peel();

            var friesTask = kitchen.FryPotatoesAsync(potato);

            Hamburger hamburger = kitchen.AssembleBurger();

            if (!friesTask.IsCompleted)
            {
                Console.WriteLine("We need to wait for the fries!");
            }

            kitchen.ServeMeal(friesTask.Result, hamburger);
            Console.ReadKey();
        }
    }
}
