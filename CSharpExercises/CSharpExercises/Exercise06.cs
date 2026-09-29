using System;
// Basic Exercise- Accepts user input and multiplies 3 numbers together
namespace CSharpExercises
{
    public class Exercise06
    {
        public static void Run()
        {
            //user welcome message and prompt for input
            Console.WriteLine("Welcome to exercise 6, this program will multiply 3 numbers together.");
            Console.WriteLine("Before we begin, let's get those numbers:");

            //prompt user for 3 numbers, re-asking until each one is valid
            double num1 = ReadNumber("Enter your first number: ");
            double num2 = ReadNumber("Enter your second number: ");
            double num3 = ReadNumber("Enter your third number: ");

            //multiply the 3 numbers together and display the result
            double result = num1 * num2 * num3;
            Console.WriteLine($"The result of multiplying {num1}, {num2}, and {num3} is: {result}");
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
}