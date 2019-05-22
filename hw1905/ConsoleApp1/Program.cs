using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator sc = new SimpleCalculator();
            AtomicCalculator ac = new AtomicCalculator();

            ac.GetNumberFromUser = sc.NumberGetter;
            ac.GetUserChoice = sc.GetUserChoice;
            ac.MentuPrinter = sc.PrintMenu;
            ac.ResultPrinter = sc.PrintresultNicely;
            ac.Calculate = sc.Calculate;

            ac.Run();
        }
    }
}
