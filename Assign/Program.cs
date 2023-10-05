using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, temp;
            Console.WriteLine("input the first Number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            //swaping the numbers 

            Console.WriteLine("After swapping");
            Console.WriteLine("first Number:" + firstNumber);
            Console.WriteLine("second Number:" + secondNumber);
        }
    }
}

     