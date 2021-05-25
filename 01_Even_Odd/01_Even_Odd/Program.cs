using System;

namespace _01_Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the digit you want to learn weather it is even or odd: ");
                string x = Console.ReadLine();

                int y = 0;
                while (!int.TryParse(x, out y))
                {
                    Console.WriteLine("This is not a valid integer. Please enter a valid value: ");
                    x = Console.ReadLine();
                }

                EvenOdd eo = new EvenOdd();
                eo.EvenOdd1(y);

                Console.WriteLine("Press any number to continue or press n to exit ");
                string p = Console.ReadLine();

                if (p == "n")
                {
                    break;
                }
            }
        }
    }
}

public class EvenOdd
{
    public void EvenOdd1(int x)
    {
        if (x % 2 == 0)
        {
            Console.WriteLine("The given number is a Even: " + x);
        }
        else
        {
            Console.WriteLine("It is odd number: " + x);
        }
    }
}
