using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 2. Write a C# Sharp program to print the sum of two numbers.
namespace PrintTheSumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 50;
            int sum = num1 + num2;
            Console.WriteLine("sum of {0} and {1} = {2}", num1, num2, sum );
            Console.ReadKey();
        }
    }
}
