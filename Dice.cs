using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDice
{
    class Dice
    {
        public   delegate void mydel (string x);
        event mydel DoubleFor, Over20;
        private int Side, Current, Sum, Index;
        Random rand = new Random();
        public void Roll ()
        {
             
            Side = rand.Next(1, 7);

            if (Index < 5)
             Sum += Side;

            if (Index == 5)
            {
                Index = 0;
                Console.WriteLine("--------------------");
                if (Sum >= 20)
                {
                    Over20("Sum of the last 5 tosses is over 20");
                }
                Sum = Side;
            }
            Console.WriteLine($"You tossed number {Side}");


            if (Side == 4  && Current == 4)
             DoubleFor("You get 2 fours in the row");
             Current = Side;
            Index++;
        }

        public void RegisterEventDoublefor ( mydel f)
        {
            this.DoubleFor += f;
        }
        public void RegisterEventOver20(mydel f)
        {
            this.Over20 += f;
        }
    }
}
