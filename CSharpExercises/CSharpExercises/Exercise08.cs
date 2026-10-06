using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public class Exercise08
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to Exercise 8!");
            Console.WriteLine("In this exercise, we will explore the multiplication table.");

            Console.WriteLine("Please enter a number to generate its multiplication table:");
            double number = ReadNumber("Enter a number: ");
        }

        // Keeps asking until the user enters a valid number
        private static double ReadNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);

                try
                {
                    double value = Convert.ToDouble(Console.ReadLine());

                    // "NaN" and "Infinity" parse successfully but are not usable numbers
                    if (double.IsNaN(value) || double.IsInfinity(value))
                    {
                        Console.WriteLine("Invalid input. Please enter a real number.");
                        continue;
                    }

                    return value;
                }
                catch (FormatException)
                {
                    // empty input, letters, symbols, etc.
                    Console.WriteLine("Invalid input. Please enter numbers only (e.g. 5 or 3.14).");
                }
                catch (OverflowException)
                {
                    // number too large or too small for a double
                    Console.WriteLine("That number is too large. Please enter a smaller number.");
                }
            }
        }
    }
