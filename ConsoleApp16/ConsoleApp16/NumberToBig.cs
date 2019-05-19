using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class NumberToBig : IPrinter
    {
        public void Print(int any)
        {
            Console.WriteLine($"{any} too big!");
        }
    }
}
