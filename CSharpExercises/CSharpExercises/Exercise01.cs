using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Basic Exercise- Accepts user input and prints a greeting*/
namespace CSharpExercises
{
    public static class Exercise01
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}