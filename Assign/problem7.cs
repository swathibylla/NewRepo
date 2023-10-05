using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class problem7
    {
        static void Main(string[] args)
        {
            int subject1, subject2, subject3;
            Console.WriteLine("Enter marks in subject1:");
             subject1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter marks in sunject 2:");
            subject2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks in subject 3:");
             subject3 = Convert.ToInt32(Console.ReadLine());


            //calculate the  percentage
            int totalMarks = subject1 + subject2 + subject3;
            double percentage = (totalMarks / 3.0);

            Console.WriteLine("TotalMarks:" + totalMarks);
            Console.WriteLine("percentage:" + percentage + "%");

            //check conditions and assign grades

            if (subject1 > 35 && subject2 > 35 && subject3 > 35)
            {
              if (percentage >= 60)
                    Console.WriteLine("Grade:First");
              else if(percentage >= 45)
                    Console.WriteLine("Grade:second");
             else if (percentage >= 35)
                    Console.WriteLine("Grade:third");
            }
            else
            {
                Console.WriteLine("Result:Fail");
            }
        }
    }
}
