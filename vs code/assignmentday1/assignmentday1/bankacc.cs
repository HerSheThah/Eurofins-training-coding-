using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentday1
{
    struct account
    {
        public int accno;
        public int balance;
    }
    internal class bankacc
    {
        static void main()
        {
            int balance = 5000;
            Console.WriteLine("Enter the acc no: ");
            int acc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To deposit amount enter 0 to withdraw amount enter 1: ");
            int choice  = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
            {
                Console.WriteLine("Enter amount: ");
                int depamount = Convert.ToInt32(Console.ReadLine());
                balance += depamount;
                Console.WriteLine("Current balance: {0}", balance);
            }
            else if (choice == 1)
            {
                Console.WriteLine("Enter amount: ");
                int withamount = Convert.ToInt32(Console.ReadLine());
                if ((balance==0)||((balance-withamount)<=0))
                {
                    Console.WriteLine("insufficient balance");
                }
                else
                {
                    balance -= withamount;
                }
                Console.WriteLine("Current balance: {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        }
    }
}
