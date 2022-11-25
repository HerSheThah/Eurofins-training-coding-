using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentday1
{
    internal class maxscore
    {
        static void Main()
        {
            Console.WriteLine("Enter maximum score");
            int maxScore = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < maxScore; i++)
            {
                congrats();
            }
        }
        static void congrats()
        {
            Console.WriteLine("Congratulations");

        }
    }
}
