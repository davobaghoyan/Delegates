using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice MyDice = new Dice();
            MyDice.RegisterEventDoublefor(new Dice.mydel(Program.f));
            MyDice.RegisterEventOver20(new Dice.mydel(Program.f1));
            for (int i = 0; i < 100; i++ )
            MyDice.Roll();
            Console.Read();
        }

        public static void f (string a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        public static void f1(string a)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(a);
            Console.ResetColor();
        }
    }
}
