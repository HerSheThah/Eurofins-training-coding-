using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentday1
{
    internal class leapyear
    {
        static void main()
        {
            Console.WriteLine("enter of date of birth: ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            int age = DateTime.Now.Year - dob.Year;
            Console.WriteLine(age);
            if((dob.Year % 4 == 0)&&((dob.Year%400==0)||(dob.Year%100!=0)))
            {
                Console.WriteLine("You are born on a leap year");
            }
            else
            {
                Console.WriteLine("You are not born on a leap year");

            }

        }
    }
}
