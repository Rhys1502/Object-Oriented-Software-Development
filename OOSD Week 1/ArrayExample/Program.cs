using System;
using System.Collections.Generic;
using System.Linq;


/*
 * Rhys Young
 * 13/9/23
 * This program is an example of arrays within C# using student details and marks to show a list of passes and fails.
 * OOSD Week 1
 * Edinburgh Napier University
 */

namespace ArrayExample
{
    internal class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();
            List<string> matriculationNumbers = new List<string>();
            List<int> marks = new List<int>();

            // Input loop to accept names and matriculation numbers
            while (true)
            {
                Console.Write("Enter student name (or leave blank to stop): ");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;

                Console.Write("Enter matriculation number: ");
                string matriculationNumber = Console.ReadLine();

                names.Add(name);
                matriculationNumbers.Add(matriculationNumber);
            }

            // Input loop to accept marks for each student
            for (int i = 0; i < names.Count; i++)
            {
                while (true)
                {
                    Console.Write($"Please enter the mark for {names[i]}: ");
                    if (int.TryParse(Console.ReadLine(), out int mark) && mark >= 0 && mark <= 100)
                    {
                        marks.Add(mark);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Mark should be in the range of 0 to 100.");
                    }
                }
            }

            // Calculate and display the average mark
            if (marks.Count > 0)
            {
                double averageMark = marks.Average();
                Console.WriteLine($"Average mark achieved: {averageMark:F2}");
            }
            else
            {
                Console.WriteLine("No marks entered.");
            }

            // Create lists of passes and fails
            List<string> passes = new List<string>();
            List<string> fails = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                if (marks[i] >= 40)
                {
                    passes.Add(names[i]);
                }
                else
                {
                    fails.Add(names[i]);
                }
            }

            // Display the lists of passes and fails
            Console.WriteLine("List of students who passed (40 or higher):");
            foreach (string student in passes)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("List of students who failed (39 or lower):");
            foreach (string student in fails)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Press Enter to end the program");
            Console.ReadKey();
        }
    }
}
