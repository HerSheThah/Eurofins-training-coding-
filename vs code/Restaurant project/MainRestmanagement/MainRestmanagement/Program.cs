
using System;
using Restaurantmanagementlibrary;

namespace MainRestmanagement
{
    internal class Program
    {
        public static RestaurantRepo restobj = new RestaurantRepo();
        
        static void Main()
        {
            //Console.WriteLine("Enter fname, lname, dob, sex, age and phone no: ");
            //int id = getId();
            //Console.WriteLine(id);
            //string fname = Console.ReadLine();
            //string lname = Console.ReadLine();
            //DateTime dob = DateTime.Parse(Console.ReadLine());
            //string sex = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //long phno = long.Parse(Console.ReadLine());
            //restobj.addCustomer(new Restaurantmanagementlibrary.Models.Customer(id, fname,lname,sex,dob,age, phno));
            Console.WriteLine("Enter id to delete: ");
            int id = int.Parse(Console.ReadLine());
            restobj.deleteCustomer(id);
            restobj.displayCustomer();


        }

        private static int getId()
        {
            Random rand = new Random();
            int transId = rand.Next(99999,1000000);
            return transId;
        }
    }
}

