using System;

namespace CSharpExercises
{
    public class Exercise05
    {
        public static void Run() {
            //Swap two numbers without using a third variable
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        }
    }
}
