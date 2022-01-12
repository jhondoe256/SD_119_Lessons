using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Async
{
    public class Kitchen
    {
        public async Task<Fries> FryPotatoesAsync(Potato potato)
        {
            if (potato.IsPeeled)
            {
                PrettyPrint("Dropping the fries in the fryer", 14);
                // await means the rest of the thread can continue but this method cannot. FryPotatoesAsync stops here but the rest of the thread continues, as we'll see...
                await Task.Delay(5000);
                PrettyPrint("Fries are still cooking", 14);
                await Task.Delay(5000);
                PrettyPrint("Ding! Fries are done", 14);
                return new Fries(potato);
            }
            else
            {
                PrettyPrint("This potato needs to be peeled first", 14);
                return null;
            }
        }

        public Hamburger AssembleBurger()
        {
            var time = 3000;

            PrettyPrint("Assembling the hamburger", 13);
            PrettyPrint("Placing the bottom bun", 4);
            Task.Delay(time).Wait();
            PrettyPrint("Placing the patty delicately", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Placing the cheese slice gingerly", 6);
            Task.Delay(time).Wait();
            PrettyPrint("Grabbing some lettuce", 10);
            Task.Delay(time).Wait();
            PrettyPrint("Throwing down some pickles", 2);
            Task.Delay(time).Wait();
            PrettyPrint("Slathering on some ketchup and mustard", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Placing top bun", 4);
            PrettyPrint("Burger Assembled!", 13);
            return new Hamburger();
        }

        public bool ServeMeal(Fries fries, Hamburger burger)
        {
            if (fries == null)
            {
                PrettyPrint("Your fries weren't ready :(", 9);
                return false;
            }
            Console.WriteLine("You put the fries with the burger. Meal is ready!");
            return true;
        }

        public void PrettyPrint(string process, int color)
        {
            Console.ForegroundColor = (ConsoleColor) color;
            Console.WriteLine(process);
            Console.ResetColor();
        }
    }
}
