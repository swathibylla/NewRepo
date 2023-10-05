using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{number} {number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}{number}");
            Console.WriteLine($"{number} {number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}{number}");
        }
    }
}
