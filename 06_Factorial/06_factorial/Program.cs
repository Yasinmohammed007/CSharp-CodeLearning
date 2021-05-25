using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Factorial calculation\t");
            Console.WriteLine("---------------------\n");

            while (true)
            {
                string x, op;
                int y;

                Console.WriteLine("Enter the integerial value: ");
                x = Console.ReadLine();

                while (!int.TryParse(x, out y))
                {
                    Console.WriteLine("Enter the value in correct integer format: ");
                    x = Console.ReadLine();
                }

                Program.Factorial(y);

                Console.WriteLine("Press n to exit or any key to continue");
                op = Console.ReadLine();

                if (op == "n")
                {
                    break;
                }

            }
        }

        static void Factorial(int x)
        {
            int y = x;
            int temp = 1;
            while (x > 0)
            {
                temp = temp * x;
                x--;
                
            }
            Console.WriteLine("The factorial number for {0} is {1}", y, temp);
        }
    }
}
