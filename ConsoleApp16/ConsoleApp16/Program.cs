using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Guesser g = new Guesser(10);

            NumberToBig ntb = new NumberToBig();
            g.TooBig = ntb.Print;

            NumberToSmall nts = new NumberToSmall();
            g.TooSmall = nts.Print;

            Bingo b = new Bingo();
            g.Bingo = b.Print;

            g.Guessing(1);
            g.Guessing(11);
            g.Guessing(10);
        }
    }
}
