using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, count = 0;

            Console.WriteLine("Please enter a number"); //Ask User to enter a number
            num1 = Convert.ToInt32(Console.ReadLine()); // Read User's number and convert to an integer

            Console.Write($"The factors of {num1} are "); // Show the factor of the number that user has input

            for (int i = 1; i <= num1; i++)  //Calculate the factor of the input
            {
                if (num1 % i == 0) 
                {
                    Console.Write(i + " "); // The answer after the calculation
                }
            }
            Console.ReadKey(); //Keep the window open
        }

    }
}
