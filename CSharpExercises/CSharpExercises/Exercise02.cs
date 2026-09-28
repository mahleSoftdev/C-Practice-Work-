using System;

namespace CSharpExercises
{
    public static class Exercise02
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter a second number: ");
            int number2 = int.Parse(Console.ReadLine() ?? "");

            int sum = number + number2;
            Console.WriteLine("The sum is: " + sum);
        }
    }
}