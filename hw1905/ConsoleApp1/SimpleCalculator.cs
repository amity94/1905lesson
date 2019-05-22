using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SimpleCalculator
    {
        public int NumberGetter()
        {
            int result = -1;
            while (result < 0)
            {
                Console.WriteLine("Please enter a number");
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Please choose from your menu");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }

        public int GetUserChoice()
        { 
            int result = -1;
            while(result<0 || result >5)
            {
                PrintMenu();
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }

        public double Calculate(int a, int b, int c)
        {
            while (c > 0 && c < 5)
            {
                switch (c)
                {
                    case 1:
                        return a + b;
                    case 2:
                        return a - b;
                    case 3:
                        return a * b;
                    case 4:
                        return a / b;
                }
            }
            return c;
        }

        public void PrintresultNicely(double a)
        {
            Console.WriteLine($"*****{a}******");
        }
    }
}
