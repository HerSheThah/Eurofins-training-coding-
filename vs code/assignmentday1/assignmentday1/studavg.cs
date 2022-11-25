
using System;
namespace FirstConsoleApp
{
    internal class studavg
    {
        static void main()
        {
            Console.WriteLine("Enter your Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Five Marks");
            int[] marks = new int[5];
            int avg = 0;
            for(int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                avg += marks[i];
            }
            avg = avg / 5;
            String feedback = "";
            if(avg > 90)
            {
                feedback= "outstanding";
            }
            else if (avg >65)
            {
                feedback = "Excellent";
            }
            else if (avg >40)
            {
                feedback = "good";
            }
            else
            {
                feedback = "fail";
            }
            Console.WriteLine("{0} your average is {1}. {2}", name,avg, feedback);



            


        }
    }
}

