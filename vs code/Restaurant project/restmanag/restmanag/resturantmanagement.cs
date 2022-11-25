using System;

namespace restmanag
{
    internal class CustomerDetails
    {
        int custid;
        String fname;
        String lname;
        String address;
        int phoneno;

        public void getdata()
        {
            Console.WriteLine("Enter custid: ");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fname: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter lname: ");
            lname = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            phoneno = Convert.ToInt32(Console.ReadLine());

        }

        public void displaydata()
        {
            Console.WriteLine("Cusid: {0}", custid);
            Console.WriteLine("Name: {0}", fname, lname);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Phoneno: {0}", phoneno);

        }
        public void validatephone()
        {
            int count = 0;
            while (phoneno > 0)
            {
                phoneno /= 10;
                count++;
            }

            if (count == 10)
            {
                Console.WriteLine("Valid phone number");
            }
            else
            {
                Console.WriteLine("Invalid phone number");
            }
        }
    }

     internal class OrderDetails
    {
        int orderid;
        int custid;
        int menuid;
        int quantity;
        float totalprice;
        DateTime orderdate;

        public void getData()
        {
            Console.WriteLine("Enter orderid");
            orderid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter custid: ");
            orderid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter menuid: ");
            menuid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total price: ");
            totalprice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter date: ");
            orderdate = DateTime.Now;

        }
        public void displaydata()
        {
            Console.WriteLine("date: {0}", orderdate);
        }
    }

    internal class MenuDetails
    {
        int menuid;
        string menuName;
        float price;
        string category;
        static int ele=0;

        public void getdata()
        {
            Console.WriteLine("Enter menuid, menuname, category, price: ");
            menuid = Convert.ToInt32(Console.ReadLine());
            menuName = Console.ReadLine();
            category = Console.ReadLine();
            price = float.Parse(Console.ReadLine());
            Console.WriteLine(menuName);

        }

    }




}



