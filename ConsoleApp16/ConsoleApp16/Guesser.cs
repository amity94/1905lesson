using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Guesser
    {
        public int Number { get; set; }

        public Action<int> TooBig { get; set; }
        public Action<int> TooSmall { get; set; }
        public Action<int> Bingo { get; set; }

        public Guesser(int number)
        {
            this.Number = number;
        }

        public void Guessing(int guess)
        {
            if (guess > Number)
            {
                TooBig.Invoke(guess);
            }
            else if (guess < Number)
            {
                TooSmall.Invoke(guess);
            }
            else
                Bingo.Invoke(guess);
        }
    }
}
