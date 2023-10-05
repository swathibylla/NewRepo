using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem8
    {
     static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            //conversion to kelvin
            //conversion to fahrenheit

            double kelvin = celsius + 273.15;
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Temperature in kelvin:{kelvin}");
            Console.WriteLine($"Temperature in fahrenheit:{fahrenheit}");

        }
    }
}
