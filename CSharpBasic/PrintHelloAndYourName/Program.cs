using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor 
 * Expected Output :
 * Hello: Alexandra Abramov
 */

namespace PrintHelloAndYourName
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fullname = "Abdullah GOLAM";
            Console.WriteLine("Hello: {0}", Fullname);
            Console.ReadKey();
        }
    }
}
