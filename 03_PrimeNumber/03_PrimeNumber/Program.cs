using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number detection\t");
            Console.WriteLine("----------------------\n");

            string x;
            string op;
            int y;

            while (true)
            {
                Console.WriteLine("Enter the value: ");
                x = Console.ReadLine();

                while (!int.TryParse(x, out y))
                {
                    Console.WriteLine("The entered value is not integer, try again: ");
                    x = Console.ReadLine();
                }

                Program.Prime1(y);

                Console.WriteLine("Press n to exit, any key to continue\t");
                op = Console.ReadLine();
                if (op == "n")
                {
                    break;
                }



            }
            
        }

        static void Prime1(int x)
        {
            int d = x / 2;
            int i;

            if (x == 2 || x == 3 || x ==1)
            {
                Console.WriteLine("This is a prime number {0}. And enter higher numbers please", x);
            }

            for (i = 2; i <= d; i++)
            {

                int reminder = x % i;

                if (reminder == 0)
                {
                    Console.WriteLine("This is not a prime number {0}", x);
                    break;
                }
                else if (reminder != 0)
                {
                    if (i == d)
                    {
                        Console.WriteLine("This is a prime number {0}", x);
                    }
                    continue;
                }
            }
           
        }
    }
}
