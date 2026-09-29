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
            Console.WriteLine("Before we bring lets get those numbers:");

            //prompt user for 3 numbers and store them in variables
            Console.WriteLine("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your third number:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            //multiply the 3 numbers together and display the result
            double result = num1 * num2 * num3;
            Console.WriteLine($"The result of multiplying {num1}, {num2}, and {num3} is: {result}");

        }
    }
}
