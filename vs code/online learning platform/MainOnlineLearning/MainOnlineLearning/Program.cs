using System;
using OnlineLearningLibrary;

namespace MainOnlineLearning
{
    internal class Program
    {
        public static OnlineLearningRepo repo = new OnlineLearningRepo(); 
        static void Main()
        {
            //Console.WriteLine("Enter dept name: ");
            //string deptname = Console.ReadLine();
            //repo.addDept(deptname);

            //repo.displaydept();

            //Console.WriteLine("ENter instructor fname, lname, sex, age, yrs of exp: ");
            //string fname = Console.ReadLine();
            //string lname = Console.ReadLine();
            //string sex = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //int yrsOfExp= int.Parse(Console.ReadLine()) ;
            //repo.addInstructor(new Instructor(fname, lname, sex, age, yrsOfExp));

            //repo.displayInstructor();

            Console.WriteLine("ENter course name, price, rating, deptid, instructorid: ");
            string coursename = Console.ReadLine();
            float price = float.Parse(Console.ReadLine());
            int rating = int.Parse(Console.ReadLine());
            int deptid = int.Parse(Console.ReadLine());
            int instructorid= int.Parse(Console.ReadLine());
            repo.addCourse(new Courses(coursename, price, rating, deptid, instructorid));
            repo.displayCourse();


        }
    }
}

