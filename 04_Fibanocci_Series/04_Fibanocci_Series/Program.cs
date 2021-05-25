using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fibanocci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Fibonacci Series\t");
                Console.WriteLine("----------------\n");

                string x, op;
                int y = 0;

                Console.WriteLine("Enter how many Fibonacci values you want to know: ");
                x = Console.ReadLine();

                while(!int.TryParse(x , out y))
                {
                    Console.WriteLine("The entered value is not an Interger, please enter again: ");
                    x = Console.ReadLine();
                }

                Program.Fibanocci(y);

                Console.WriteLine("\nPress n to exit or any ket to continue");
                op = Console.ReadLine();

                if (op == "n")
                {
                    break;
                }
            }
        }

        static void Fibanocci(int x)
        {

            long i = 1;
            long j = 1;
            long fib = 0;

            //int will have only 2^32. so, you will see negative values
            //long has more value, still you will see negative values

            Console.Write("1 1 ");

            for (int z =0; z <= x; z++)
            {
                fib = i + j;
                Console.Write("{0} ", fib);
                i = j;
                j = fib;

               
            }



        }
    }
}
