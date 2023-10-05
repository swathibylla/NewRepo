using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem2
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, result;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            num3 = Convert.ToDouble(Console.ReadLine());

            result = num1 * num2 * num3;
            Console.WriteLine("result:" + result);

        }
    }
}

    
