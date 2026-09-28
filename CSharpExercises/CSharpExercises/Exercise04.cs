using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public class Exercise04
    {
        public static void Run()
        {
            //Printing the results of specified mathematical operations

            //OP1
            int a = -1;
            int b = 4;
            int c = 6;
            int result = a + b * c;
            Console.WriteLine(result);

            //OP2
            int d = 35;
            int e = 5;
            int f = 7;
            int result2 = (d + e) % f;
            Console.WriteLine(result2);

            //OP3
            int g= 14;
            int h = -4;
            int i = 6;
            int result3 = g + h * i / 11;
            Console.WriteLine(result3);

            //OP4
            int j = 2;
            int k = 15;
            int l = 6;
            int m = 1;
            int n = 7;
            int result4 = j + k / l * m - n % 2;
            Console.WriteLine(result4);

        }

    }
}
