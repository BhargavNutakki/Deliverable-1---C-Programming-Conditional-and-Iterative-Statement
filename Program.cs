using System;
namespace Delivarabe_1b_
{
    class Program
    {


        static void Main(string[] args)
        {
            int max = 0;
            while (true) 
            {
                try
                {
                    Console.WriteLine("Enter an integer between 1 and 100: ");
                    max = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Only integer numbers are allowed");
                }
            }

            Console.WriteLine("Specify series (odd/even): ");
            string series = Console.ReadLine().ToLower();

            Console.WriteLine("You have selected the ", series, " series. The numbers between 0 and ", max, " are: ");

            if (series == "odd")
            {
                for (int i = 1; i <= max; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            if (series == "even")
            {
                for (int i = 1; i <= max; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}