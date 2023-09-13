using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Rhys Young
 * 13/9/23
 * This program will differntiate between an odd and even number.
 * OOSD Week 1
 * Edinburgh Napier University
 */

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());

            // Check is number is modulus of 2, if so number is even
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.WriteLine("Press enter to end");
            Console.ReadKey();
        }
    }
}
