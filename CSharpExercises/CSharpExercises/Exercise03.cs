using System;
/*Basic Exercise- Accepts two numbers from the user and prints their division result*/
namespace CSharpExercises
{
    public class Exercise03
    {
        public static void Run() {
            //Get user input
            Console.WriteLine("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Enter a second number: ");
            double num2 = double.Parse(Console.ReadLine() ?? "");

            //Devide the two numbers
            int result = num1 / num2;
            Console.WriteLine("The result of dividing " + num1 + " by " + num2 + " is: " + result);
        }
    }
}
