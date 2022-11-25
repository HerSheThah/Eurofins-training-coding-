using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurantmanagementlibrary.Models;

namespace Restaurantmanagementlibrary
{
    public class RestaurantRepo
    {
        restmanagementDBContext restdb = new restmanagementDBContext();
        Customer cust = new Customer();

        public void addCustomer(Customer newcustomer)
        {
            using(var restdb = new restmanagementDBContext())
            {
                cust.Custid= newcustomer.Custid;
                cust.Fname= newcustomer.Fname;
                cust.Lname = newcustomer.Lname;
                cust.Sex = newcustomer.Sex;
                cust.Dob = newcustomer.Dob;
                cust.Age = newcustomer.Age;
                cust.Phno = newcustomer.Phno;
                restdb.Customers.Add(cust);
                restdb.SaveChanges();
            }
        }

        public void deleteCustomer(int custid)
        {
            using(var restd = new restmanagementDBContext())
            {
                cust = restdb.Customers.Find(custid);
                restdb.Customers.Remove(cust);
                restdb.SaveChanges();
            }
        }

        public void updateCustomer()
        {
            throw new NotImplementedException();
        }
        public void displayCustomer()
        {
            using(var restdb = new restmanagementDBContext())
            {
                foreach(var item in restdb.Customers)
                {
                    Console.WriteLine(item.Custid + " " + item.Fname + " " + item.Lname + " " + item.Age + " " + item.Sex + " " + item.Dob + " " + item.Phno);
                }
            }
        }
        
    }
}
