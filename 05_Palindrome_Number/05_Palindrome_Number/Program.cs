using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Palindrome Number check\t");
                Console.WriteLine("-----------------------\n");

                string x, op;
                int y;

                Console.WriteLine("Enter the number to know weather it is palindrome or not:");
                x = Console.ReadLine();

                while (!int.TryParse(x, out y))
                {
                    Console.WriteLine("The entered number is not an integer, please enter again: ");
                    x = Console.ReadLine();
                }

                Program.Palindrome(y);

                Console.WriteLine("Press n to exit or any other key to continue");
                op = Console.ReadLine();

                if (op == "n")
                {
                    break;
                }

            }
        }

        static void Palindrome(int x)
        {

            int sum = 0;
            int reminder;
            int temp = x;

            while (x > 0)
            {
                reminder = x % 10; // extracts the last number of the given input Dividend
                sum = (sum * 10) + reminder; // Multiplies by 10 and adds the reminder
                x = x / 10; // The x will be replaced with quotient

                //This way the input number can be reversed

            }

            if ( temp == sum)
            {
                Console.WriteLine("The entered number is a Palindrome {0}", temp);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome number", temp);
            }

        }
    }
}
