using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Async
{
    public class Potato
    {
        public Potato()
        {
            IsPeeled = false;
        }

        public Potato(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public bool IsPeeled { get; private set; }

        public bool Peel()
        {
            Console.WriteLine("Started peeling potato");
            Task.Delay(2000).Wait();

            IsPeeled = true;
            Console.WriteLine("You have peeled the potato");
            return true;
        }
    }

    public class Fries
    {
        public Fries(Potato potato)
        {

        }
    }

    public class Hamburger { }
}
