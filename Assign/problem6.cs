using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem6
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
             num2 = Convert.ToDouble(Console.ReadLine());

            double max = Math.Max(num1, num2);
            double min = Math.Min(num1, num2);

            Console.WriteLine("Maximum number:" + max);
            Console.WriteLine("Minimum number:" + min);
        }
    }
}
