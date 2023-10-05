using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem_3
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("enter the first number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());

            double addition = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine("Result");
            Console.WriteLine("Addition:" + addition);
            Console.WriteLine("subtraction:" + subtraction);
            Console.WriteLine("multiplication:" + multiplication);
            Console.WriteLine("division:" + division);
        }
    }
}
