using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 4. Write a C# Sharp program to print the result of the specified operations. Go to the editor
 * Test data:
 * -1 + 4 * 6
 * ( 35+ 5 ) % 7
 * 14 + -4 * 6 / 11
 * 2 + 15 / 6 * 1 - 7 % 2
 */

namespace printTheResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1 + 4 * 6;
            int y = (35 + 5) % 7;
            int z = 14 + -4 * 6 / 11;
            int s = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(" x = {0}\n y = {1}\n z = {2}\n s = {3}\n", x, y, z, s);

            Console.ReadKey();
        }
    }
}
