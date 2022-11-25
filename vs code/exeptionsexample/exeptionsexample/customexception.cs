using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeptionsexample
{
    internal class accnumberException : ApplicationException
    {
        public accnumberException(string message) : base(message) { }
    }
    internal class balanceexception: ApplicationException
    {
        public balanceexception(string message) : base(message) { }
    }

    public class account
    {

        decimal balance = 2000;
        public void getaccount()
        {
            long accno = long.Parse(Console.ReadLine());

            if ((accno > 999999999) && (accno < 10000000000))
                Console.WriteLine("Account no accepted");
            else
                throw new accnumberException("Account number should contain 10 digits");

        }
        public void withdraw(decimal amt )
        {

            if (balance - amt < 0)

                throw new balanceexception("Insufficient balance ");

            else
                balance -= amt;

            Console.WriteLine("Current balance: " + balance);

        }

        static void main()
        {
            account acc = new account();
            try
            {
                acc.getaccount();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                decimal amt = decimal.Parse(Console.ReadLine());
                acc.withdraw(amt);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
        

        

    }



    

