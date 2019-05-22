using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MentuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }

        public void Run()
        {
            this.X = GetNumberFromUser.Invoke();
            this.Y = GetNumberFromUser.Invoke();
            MentuPrinter.Invoke();
            int mathchoice = GetUserChoice.Invoke();
            double result = Calculate.Invoke(X, Y, mathchoice);
            ResultPrinter.Invoke(result);
        }
    }
}
