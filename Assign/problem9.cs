using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem9
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if(num1 == num2)
            {
                int result = 3 * sum;
                Console.WriteLine("the numbers are equal  so three  times their sum is:" + result);
            }
            else
            {
                Console.WriteLine("The sum of the two numbers is:" + sum);
            }

        }
    }
}
