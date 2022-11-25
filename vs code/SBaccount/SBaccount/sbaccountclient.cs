using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBAccount
{
    internal class sbaccountclient
    {
        static void Main()
        {
            
            int n = 4;


            // new ob - calling functions for initialisation
            SBAccountCreation acc1 = new SBAccountCreation();
            acc1.getAccountDetails();
            acc1.showAccountdDetails();
            acc1.AccNum = 1234;

            // new ob - using properties
            SBAccountCreation acc2 = new SBAccountCreation();
            acc2.AccNum = 3456;
            acc2.AccHold = "jesi";
            acc2.accType = "savings";
            acc2.showAccountdDetails();

            // using loop creating with constructor
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter account number: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Account holder name: ");
                String accountHolderName = Console.ReadLine();
                Console.WriteLine("Account type: ");
                String typeofAccount = Console.ReadLine();
                SBAccountCreation newacc = new SBAccountCreation(accountNumber, accountHolderName, typeofAccount);
                newacc.showAccountdDetails();
                
            }

        }
    }
}
