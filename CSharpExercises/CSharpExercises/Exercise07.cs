using System;


namespace CSharpExercises
{
    public class Exercise07
    {
        public static void Run() 
        {
            Console.WriteLine("Welcome to Exercise 7!");
            Console.WriteLine("This exercise will show how arithmetic operations work in C#.");

            //Prompt the user for two numbers 
            double num1 = ReadNumber("Enter your first number: ");
            double num2 = ReadNumber("Enter your second number: ");

            Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
            Console.WriteLine($"The difference of {num1} and {num2} is: {num1 - num2}");
            Console.WriteLine($"The product of {num1} and {num2} is: {num1 * num2}");
            Console.WriteLine($"The quotient of {num1} and {num2} is: {num1 / num2}");

        }

        //Exception Handling for invalid inputs
        public static double ReadNumber(string prompt)
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
