using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Rhys Young
 * 13/9/23
 * This program will produce an output based on the users input values.
 * OOSD Week 1
 * Edinburgh Napier University
 */

namespace HelloUser
{
    internal class Program

    {
        static void Main()
        {
            string name;
            string matriculationNumber;

            while (true)
            {
                // Prompt the user to enter their name
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                // Check if the name is blank
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: Name cannot be blank. Please try again.");
                    continue; // Restart the loop to re-enter the name
                }

                // Prompt the user to enter their matriculation number
                Console.Write("Enter your matriculation number: ");
                matriculationNumber = Console.ReadLine();

                // Check if the matriculation number is a valid integer and 8 digits long
                if (int.TryParse(matriculationNumber, out int matriculationNumberInt) && matriculationNumber.Length == 8)
                {
                    // Check if the matriculation number starts with '4'
                    if (matriculationNumber.StartsWith("4"))
                    {
                        break; // Valid name and matriculation number, exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Error: Matriculation number must start with '4'. Please try again.");
                    }
                }
                else if (matriculationNumber.Length > 8)
                {
                    Console.WriteLine("Error: Number too long. Matriculation number should be 8 digits long. Please try again.");
                }
                else
                {
                    Console.WriteLine("Error: Invalid matriculation number format or number too short. Please try again.");
                }
            }

            // Print the message
            Console.WriteLine($"Hello {name}, your matriculation number is {matriculationNumber}");
        }
    }
}

