using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            if(num1> num2)
            {
                double result = 2 * difference;
                Console.WriteLine("The first number is greater, two times the absolute difference is:" + result);
            }
            else
            {
                Console.WriteLine("The absolute difference between the two numbers is:" + difference);

            }
        }
    }
}
