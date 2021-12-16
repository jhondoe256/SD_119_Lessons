using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UI
{
    class Program
    {
        // static int count = 0;
        // static means there's only one for the whole class
        // non-static methods are called instance methods - they apply to a specific instance
        static void Main(string[] args)
        {
            // count++;
            ProgramUI ui = new ProgramUI();

            ui.Run();
        }
    }
}
