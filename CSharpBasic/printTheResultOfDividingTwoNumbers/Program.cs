using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 3. Write a C# Sharp program to print the result of dividing two numbers
 */
namespace printTheResultOfDividingTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            int r = num1 / num2;
            Console.WriteLine("Division of {0} and {1} = {2} ", num1, num2, r);

            Console.ReadKey();
        }
    }
}
