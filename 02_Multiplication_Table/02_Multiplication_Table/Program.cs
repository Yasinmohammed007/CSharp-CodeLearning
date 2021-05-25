using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string x;
                string op;
                double y;

                Console.WriteLine("Enter the value for multiplication table: ");
                x = Console.ReadLine();

                while (!double.TryParse(x, out y))
                {
                    Console.WriteLine("The Enetered value is not a numerical value, please enter again: ");
                    x = Console.ReadLine();
                }

                Program.Multiplication(y);

                Console.WriteLine("Press any number to continue or press n to exit");
                op = Console.ReadLine();

                if (op == "n")
                {
                    break;
                }
            }
        }

        static void Multiplication(double x)
        {
            for (int i=0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", x,i,x*i);
            }
        }
    }
}
