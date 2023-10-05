using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem4
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Enter the value for x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the  value for z:");
            z = Convert.ToDouble(Console.ReadLine());

            double result1 = (x + y) * z;
            double result2 = (x * y + y * z);

            Console.WriteLine("Result of (x + y)* z:" + result1);
            Console.WriteLine("Result of (x* y + y * z):" + result2);
        }
    }
}
