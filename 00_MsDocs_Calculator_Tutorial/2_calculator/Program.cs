using System;

namespace _2_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Enter the first digit:\n");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second digit:\n");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option to perfrom the calulator functions:");
            Console.WriteLine("\ta-add");
            Console.WriteLine("\ts-subtraction");
            Console.WriteLine("\tm-multiplication");
            Console.WriteLine("\td-divide");
            Console.WriteLine("your option?:");

            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} =" + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} =" + (num1 * num2));
                    break;
                case "d":

                    while(num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} =" + (num1 / num2));
                    break;             
            }

            Console.WriteLine("Press any key to close the calculator console app...");
            Console.ReadKey();

        }
    }
}
