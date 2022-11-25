using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentday1
{
    internal class welsomestud
    {
        static void main()
        {
            Console.WriteLine("Enter no of students: ");
            int noOfStud = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= noOfStud; i++)
            {
                Console.WriteLine("Welcome Student {0}", i);
            }
        } 
    }
}
